﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KnowledgeOption : MonoBehaviour {
	public static Button Woodworker;
	public static Button MetalFabrication;
	public static Button ChainSteel;
	public static Button MetalProcessing;
	public static Button Crafts;
	public static Button Geometry;
	public static Button Physics;
	public static Button Chemistry;
	public static Button PeriodicTable;
	public static Button Pulley;
	public static Button Anatomy;
	public static Button Catapult;
	public static Button GunpowderModulation;
	public static Button Psychology;
	public static int knowledge;
	public static string knowledgeName;

	public static void AssignButton(GameObject panel){
		Woodworker = panel.transform.GetChild (2).GetChild (0).GetComponent<Button>();
		MetalFabrication = panel.transform.GetChild (2).GetChild (1).GetComponent<Button>();
		ChainSteel = panel.transform.GetChild (2).GetChild (2).GetComponent<Button>();
		MetalProcessing = panel.transform.GetChild (2).GetChild (3).GetComponent<Button>();
		Crafts = panel.transform.GetChild (2).GetChild (4).GetComponent<Button>();
		Geometry = panel.transform.GetChild (2).GetChild (5).GetComponent<Button>();
		Physics = panel.transform.GetChild (2).GetChild (6).GetComponent<Button>();
		Chemistry = panel.transform.GetChild (2).GetChild (7).GetComponent<Button>();
		PeriodicTable = panel.transform.GetChild (2).GetChild (8).GetComponent<Button>();
		Pulley = panel.transform.GetChild (2).GetChild (9).GetComponent<Button>();
		Anatomy = panel.transform.GetChild (2).GetChild (10).GetComponent<Button>();
		Catapult = panel.transform.GetChild (2).GetChild (11).GetComponent<Button>();
		GunpowderModulation = panel.transform.GetChild (2).GetChild (12).GetComponent<Button>();
		Psychology = panel.transform.GetChild (2).GetChild (13).GetComponent<Button>();
	}

	public static void AddButtonListener(GameObject panel,GameObject parent){
		Woodworker.onClick.AddListener (() => {
			knowledge = 2001;
			knowledgeName = "Woodworker";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		MetalFabrication.onClick.AddListener (() => {
			knowledge = 2002;
			knowledgeName = "MetalFabrication";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		ChainSteel.onClick.AddListener (() => {
			knowledge = 2003;
			knowledgeName = "ChainSteel";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		MetalProcessing.onClick.AddListener (() => {
			knowledge = 2004;
			knowledgeName = "MetalProcessing";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			};
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Crafts.onClick.AddListener (() => {
			knowledge = 2005;
			knowledgeName = "Crafts";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Geometry.onClick.AddListener (() => {
			knowledge = 2006;
			knowledgeName = "Geometry";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Physics.onClick.AddListener (() => {
			knowledge = 2007;
			knowledgeName = "Physics";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Chemistry.onClick.AddListener (() => {
			knowledge = 2008;
			knowledgeName = "Chemistry";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		PeriodicTable.onClick.AddListener (() => {
			knowledge = 2009;
			knowledgeName = "PeriodicTable";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Pulley.onClick.AddListener (() => {
			knowledge = 2010;
			knowledgeName = "Pulley";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Anatomy.onClick.AddListener (() => {
			knowledge = 2011;
			knowledgeName = "Anatomy";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Catapult.onClick.AddListener (() => {
			knowledge = 2012;
			knowledgeName = "Catapult";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		GunpowderModulation.onClick.AddListener (() => {
			knowledge = 2013;
			knowledgeName = "GunpowderModulation";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
		Psychology.onClick.AddListener (() => {
			knowledge = 2014;
			knowledgeName = "Psychology";
			if (AcademySelfLearn.isSelfStudy){
				parent.GetComponent<Academy>().ConfirmTraining.SetActive(true);
			}else{
				parent.GetComponent<Academy>().ConfirmTeacherBy.SetActive(true);
			}
			parent.GetComponent<Academy>().KnowledgeListHolder.SetActive(false);
		});
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnKnowledgeButtonClicked(Button btn){
		string name = btn.transform.GetChild(0).GetComponent<Text>().text;
		Debug.Log (name);
	}
}
