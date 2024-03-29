using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Services;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UniRx;
using UnityEngine;
using Gamelogic.Grids;
using DG.Tweening;
using UnityEngine.UI;


public class EntityView : EntityViewBase {
	public GameObject healthBar;
	private bool _destroy = false;
	public Text panelText;

	public EntityView OpponentView 
	{
		get;
		set;
	}
	
	protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as EntityViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.Entity to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
    }

	public void RendererColor(Color color)
	{
		this.gameObject.GetComponent<Renderer>().material.color = color;
	}

	public void AtkAndUpdateHealth()
	{
		this.transform.DOPunchPosition(Vector3.right *100, 0.1f, 100, 1f, false).OnComplete(() => {
			//Debug.Log ("Update Opponent Health");
			this.OpponentView.UpdateHealth(this.Entity.Opponent.Health);
		});
	}

	public void UpdateHealth(float number)
	{
		//this.Entity.Opponent.Health = number;
		var curHealth = (float)number/this.Entity.Max_Health;
		//Debug.Log("curHealth: " + curHealth);
		
		healthBar.transform.localScale = new Vector3(curHealth, healthBar.transform.localScale.y);
	}

	// try to use UniRx when have time	
	public IEnumerator Move(Vector3 currentPoint, Vector3 endPoint, MoveStyle move){
		float time = 0;
		const float totalTime = .3f;
		
		//onAction = true;
		while (time < totalTime)
		{
			float x = Mathf.Lerp(currentPoint.x, endPoint.x, time / totalTime);
			float y = Mathf.Lerp(currentPoint.y, endPoint.y, time / totalTime);
			
			y -= 18;
			
			transform.position = new Vector3(x, y);
			time += Time.deltaTime;
		}
		
		//this._State = PlayerState.ATTACK;
		//Debug.Log ("After Move: " + this._State);
		yield return null;
		
		if(move == MoveStyle.SLOW)
			yield return new WaitForSeconds(0.3f);
		
		else if(move == MoveStyle.NORMAL)
			yield return new WaitForSeconds(0.1f);
		
		else if(move == MoveStyle.FAST)
			yield return new WaitForSeconds(0.05f);
		
		else
			yield return new WaitForSeconds(0.4f);
	}

    public override void HealthChanged(Single health) {
		if(health < 1 && !_destroy)
		{
		this.transform.DOShakeScale(0.4f, 80).OnComplete(() => this.gameObject.SetActive(false));
		ExecuteChangeHealth();
		_destroy = true;
		/*
		 if(this is SoldierView)
				MainGameRootViewModel.SoldierCount -=1;
		 else
				MainGameRootViewModel.EnemyCount -=1;
		*/
		}
    }

    public override void BattleStateChanged(BattleState bState) {
		
		//Debug.Log (this.Identifier + "BattleState: " + bState);
		
		if(bState == BattleState.CONFUSING)
		{
			panelText.text = this.Entity.Identifier + " is confusing and hit himself";
		}
		ExecuteChangeBattleState();
    }
}
