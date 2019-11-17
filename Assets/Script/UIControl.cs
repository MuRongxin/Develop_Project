using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIControl : MonoBehaviour {

	public static UIControl _instant;
	private Toggle randomToggle;
	private Toggle assignToggle;

	private Button exitButton;	

	

	private GameObject assignPanle;
	private GameObject randomBeggin;
	private GameObject resoule;

	private void Awake()
	{
		_instant=this;		

		randomToggle=transform.Find("Toggle/RandomToggle").GetComponent<Toggle>();
		assignToggle=transform.Find("Toggle/AssignToggle").GetComponent<Toggle>();
		assignPanle=transform.Find("AssignPanle").gameObject;
		randomBeggin=transform.Find("RandomBeggin").gameObject;
		resoule=transform.Find("Resoult").gameObject;

		exitButton=transform.Find("Resoult/ExitButton").GetComponent<Button>();
	}
	// Use this for initialization
	void Start () {		
		randomBeggin.GetComponent<RectTransform>().localPosition=new Vector3(-83,-88,0);
		
		assignPanle.GetComponent<RectTransform>().localPosition=new Vector3(1968,-151,0);
		assignPanle.GetComponent<RectTransform>().localScale=new Vector3(0,0,0);

		exitButton.onClick.AddListener(()=>{
		resoule.GetComponent<RectTransform>().DOScale(new Vector3(0,0,0),0.5f).OnComplete(()=>resoule.SetActive(false));
		resoule.transform.Find("bg").GetComponent<Image>().DOColor(new Color(1,1,1,0),0.5f);
		});

		randomBeggin.GetComponent<Button>().onClick.AddListener(ResoultPanle);

		resoule.transform.Find("bg").GetComponent<Image>().color=new Color(1,1,1,0);
		resoule.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(randomToggle.isOn)
		{
			assignPanle.GetComponent<RectTransform>().DOLocalMove(new Vector3(1968,-151,0),1).OnComplete(()=>assignPanle.GetComponent<RectTransform>().localPosition=new Vector3(-1968,-151,0));
			assignPanle.GetComponent<RectTransform>().DOScale(new Vector3(0,0,0),1);

			randomBeggin.GetComponent<RectTransform>().DOLocalMove(new Vector3(-83,-88,0),1);
			randomBeggin.GetComponent<RectTransform>().DOScale(new Vector3(1,1,1),1);
		}
		if(assignToggle.isOn)
		{
			assignPanle.GetComponent<RectTransform>().DOLocalMove(new Vector3(100,-151,0),1);
			assignPanle.GetComponent<RectTransform>().DOScale(new Vector3(1,1,1),1);

			randomBeggin.GetComponent<RectTransform>().DOLocalMove(new Vector3(-1352,-88,0),1);
			randomBeggin.GetComponent<RectTransform>().DOScale(new Vector3(0,0,0),1);
		}
	}
	
	public void ResoultPanle(){
		resoule.SetActive(true);
		resoule.transform.Find("bg").GetComponent<Image>().DOColor(new Color(1,1,1,1),0.5f);
		resoule.GetComponent<RectTransform>().DOScale(new Vector3(1,1,1),0.5f);
		///TODO
		///各种信息
		

	}

}
