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
using UnityEngine.UI;
using DG.Tweening;


public class MainGameRootView : MainGameRootViewBase {
    
	public Text gameOverText;
	public GSHexGridManager gSHexGridManager;

	public Button InfoButton;
	public Button InfoCloseButton;
	public Button InfoAtkButton;
	public Button InfoMoveButton;
	public Button InfoMissionButton;
	public Button StartBattleButton;

	public Button SlowButton; 
	public Button NormalButton; 
	public Button FastButton;

	public Button AttackButton;
	public Button AssaultButton;
	public Button FeintButton;
	public Button PinButton;
	public Button YawpButton;
	public Button SearchButton;
	public Button AATKButton;
	public Button StandByButton;
	
	public TextAsset atkInfo;
	public TextAsset moveInfo;
	public TextAsset missionInfo;
	public GameObject InfoPanel;
	public GameObject BlockPanel;
	public Text InfoText;

	public List<SoldierViewModel> SoldierVM = new List<SoldierViewModel>();
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
		//gameOverText = GameObject.Find("Text_GameOver").GetComponent<Text>();
		gameOverText.gameObject.SetActive(false);
		//TextAsset atkInfo = Resources.Load<TextAsset> ("ATK_Info");
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as MainGameRootViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
		InfoText.text = missionInfo.text;
		gSHexGridManager = GameObject.Find("HexMapGrid").GetComponent<GSHexGridManager>();

		for (int i = 1; i <= 5; i++)
			SoldierVM.Add(uFrameKernel.Container.Resolve<SoldierViewModel>("Soldier" + i));


	}
	
	public override void Bind() {
        base.Bind();
        // Use this.MainGameRoot to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
        
        //InfoPanel
		this.BindButtonToHandler(InfoButton, () => {
		
			if(InfoPanel.activeSelf == false)
			{
				InfoPanel.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.InOutQuad).OnStart(() =>  InfoPanel.SetActive(true));
				BlockPanel.SetActive(true);
			}
				
			else
			{
				InfoPanel.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InOutQuad).OnComplete(() => InfoPanel.SetActive(false));
				BlockPanel.SetActive(false);	
			}
			/*
			Publish(new NotifyCommand(){
				Message = atkInfo.text 
		    });
		    */
		});
		
		this.BindButtonToHandler(InfoCloseButton, () => { 
			InfoPanel.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InOutQuad).OnComplete(() => InfoPanel.SetActive(false));
			BlockPanel.SetActive(false);
		});
		
		this.BindButtonToHandler(StartBattleButton, () => { 
			InfoPanel.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InOutQuad).OnComplete(() => InfoPanel.SetActive(false));
			BlockPanel.SetActive(false);
		});

		this.BindButtonToHandler(InfoAtkButton, () => { 
			InfoText.text = atkInfo.text;
		});

		this.BindButtonToHandler(InfoMoveButton, () => { 
			InfoText.text = moveInfo.text;
		});

		this.BindButtonToHandler(InfoMissionButton, () => { 
			InfoText.text = missionInfo.text;
		});

		//Batte Start la
		//MoveStyle
		this.BindButtonToHandler(SlowButton, () => {
			SoldierVM[gSHexGridManager.sNum].Movement = MoveStyle.SLOW;
			//this.Soldier.SoldierState = SoldierState.ATTACK;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});	
		this.BindButtonToHandler(NormalButton, () => {
			SoldierVM[gSHexGridManager.sNum].Movement = MoveStyle.NORMAL;
			//this.Soldier.SoldierState = SoldierState.ATTACK;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});	
		this.BindButtonToHandler(FastButton, () => {
			SoldierVM[gSHexGridManager.sNum].Movement= MoveStyle.FAST;
			//this.Soldier.SoldierState = SoldierState.ATTACK;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});

		//ActionStyle
		this.BindButtonToHandler(AssaultButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.ASSAULT;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			//ExecuteChangeActionStyle();
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});
		this.BindButtonToHandler(AttackButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.ATTACK;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});
		this.BindButtonToHandler(FeintButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.FEINT;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});
		this.BindButtonToHandler(PinButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.PIN;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});

		this.BindButtonToHandler(YawpButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.YAWP;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});
		this.BindButtonToHandler(SearchButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.SEARCH;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});

		this.BindButtonToHandler(AATKButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.A_ATK;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});

		this.BindButtonToHandler(StandByButton, () => {
			SoldierVM[gSHexGridManager.sNum].Action = ActionStyle.STANDBY;
			//this.Soldier.SoldierState = SoldierState.MOVE;
			gSHexGridManager.selectPoint = true;
			gSHexGridManager.MoveOrAttackPointSelected();
		});
		
    }

    public override void GameStateChanged(GameState gameState) {
		if (gameState == GameState.Playing) return;
		
		if (this.MainGameRoot.EnemyCount == 0)
		{
			Debug.Log ("You Win");
			gameOverText.text = "You Win";
			gameOverText.gameObject.SetActive(true);
			ExecuteGameOver();
		}
		
		else if(this.MainGameRoot.SoldierCount == 0)
		{
			Debug.Log ("You Lose");
			gameOverText.text = "GameOver";
			gameOverText.gameObject.SetActive(true);
			ExecuteGameOver();
		}

    }
}
