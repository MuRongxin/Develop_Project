using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using LitJson;

public class UIControl : MonoBehaviour {

	public static UIControl _instant;
	private Toggle randomToggle;
	private Toggle assignToggle;

	private Button exitButton;	
	private Text resoultName;
	private Text firstNameExplain;
	private Text lastNameExplain;

	private GameObject assignPanle;
	private GameObject randomBeggin;
	private GameObject resoule;

	private string firstName;
	private bool isRandom;

	private void Awake()
	{
		_instant=this;		

		randomToggle=transform.Find("Toggle/RandomToggle").GetComponent<Toggle>();
		assignToggle=transform.Find("Toggle/AssignToggle").GetComponent<Toggle>();
		assignPanle=transform.Find("AssignPanle").gameObject;
		randomBeggin=transform.Find("RandomBeggin").gameObject;
		resoule=transform.Find("Resoult").gameObject;

		exitButton=transform.Find("Resoult/ExitButton").GetComponent<Button>();
		resoultName=transform.Find("Resoult/ResoultName").GetComponent<Text>();
		firstNameExplain=transform.Find("Resoult/FirstNameExplain").GetComponent<Text>();
		lastNameExplain=transform.Find("Resoult/LastNameExplain").GetComponent<Text>();

	}
	// Use this for initialization
	void Start () {		
		randomBeggin.GetComponent<RectTransform>().localPosition=new Vector3(-83,-88,0);
		
		assignPanle.GetComponent<RectTransform>().localPosition=new Vector3(1968,-151,0);
		assignPanle.GetComponent<RectTransform>().localScale=new Vector3(0,0,0);

		exitButton.onClick.AddListener(()=>{
		resoule.GetComponent<RectTransform>().DOScale(new Vector3(0,0,0),0.5f).OnComplete(()=>resoule.SetActive(false));
		resoule.transform.Find("bg").GetComponent<Image>().DOColor(new Color(1,1,1,0),0.5f);
		firstNameExplain.text="";
		resoultName.text="";
		});

		randomBeggin.GetComponent<Button>().onClick.AddListener(ResoultPanle);

		resoule.transform.Find("bg").GetComponent<Image>().color=new Color(1,1,1,0);
		resoule.SetActive(false);
		JsonRead();
	}
	
	// Update is called once per frame
	void Update () {
		if(randomToggle.isOn)
		{
			isRandom=true;
			assignPanle.GetComponent<RectTransform>().DOLocalMove(new Vector3(1968,-151,0),1).OnComplete(()=>assignPanle.GetComponent<RectTransform>().localPosition=new Vector3(-1968,-151,0));
			assignPanle.GetComponent<RectTransform>().DOScale(new Vector3(0,0,0),1);

			randomBeggin.GetComponent<RectTransform>().DOLocalMove(new Vector3(-83,-88,0),1);
			randomBeggin.GetComponent<RectTransform>().DOScale(new Vector3(1,1,1),1);
		}
		if(assignToggle.isOn)
		{
			isRandom=false;
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
		Debug.Log(AssignPanle.iniputFirstName.text);
		if(isRandom)
		{
			resoultName.text=RandomName();
			firstNameExplain.text=firstName+": "+ GetFirstNameExplain();
		}
		else
		{
			
		}
	}

	private string RandomName()
	{		
		int fistNameType=Random.Range(0,2);
		if(fistNameType==0) //aloneFirstName
		{
			firstName=Initinfo.aloneFirstName[Random.Range(0,Initinfo.aloneFirstName.Count)];
		}
		else //twoFirstName
		{
			firstName=Initinfo.twoFirstName[Random.Range(0,Initinfo.twoFirstName.Count)];
		}

		return firstName;
	}

	private string GetFirstNameExplain()
	{		
		return Initinfo.firstNameInfoDic[firstName];
	}

	private void AssignCondition()
	{
		if(AssignPanle.isAssignFirstName)
		{
			firstName=AssignPanle.iniputFirstName.text;
		}
		else
		{
			
		}
	}

	private void JsonRead()
	{
		string json="";
		TextAsset text=Resources.Load<TextAsset>("word");
		if(!string.IsNullOrEmpty(json))
			json=text.text;
		if(text!=null)
			Debug.Log(text.text);

		if(string.IsNullOrEmpty(json)){}
			//return null;

			StreamReader streamreader = new StreamReader(Application.dataPath + "/StreamingAssets/word.json");//读取数据，转换成数据流
            JsonReader json1 = new JsonReader(streamreader);//再转换成json数据
           	Debug.Log(json1.Value);

		
		//return json;
	}

}
