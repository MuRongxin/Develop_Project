using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AssignPanle : MonoBehaviour {

	[HideInInspector]
	public static InputField iniputFirstName;
	public static bool isNormalFirstName;
	public static int lastnameCount;
	public static string lastNameType;
	private GameObject firstNameType;
	private RectTransform toggleMove;
	
	public Toggle toggle_FirstNameType;
	public ToggleGroup toggle_lastNameType;
	IEnumerable<Toggle> toggleGrouplastNameType;
	public ToggleGroup toggle_lastNameCount;
	IEnumerable<Toggle> toggleGrouplastNameCount;
	public static bool isAssignFirstName;
	private bool isMove;

	private Button beggin;

	// Use this for initialization
	void Start () {
		iniputFirstName=transform.Find("InputFirstName").GetComponent<InputField>();
		firstNameType=transform.Find("ToggleFirstNameType").gameObject;
		beggin=transform.Find("ToggleMove/Beggin").GetComponent<Button>();
		toggleMove=transform.Find("ToggleMove").GetComponent<RectTransform>();
		beggin.onClick.AddListener(UIControl._instant.ResoultPanle);
		

	}
	
	// Update is called once per frame
	void Update () {
		if(iniputFirstName.text=="")
		{
			isAssignFirstName=false;
			firstNameType.SetActive(true);
			if(isMove==true)
				toggleMove.DOLocalMoveY(toggleMove.localPosition.y-115,0.6f);
			isMove=false;
		}
		else
		{
			isAssignFirstName=true;
			firstNameType.SetActive(false);
			if(!isMove)
				toggleMove.DOLocalMoveY(toggleMove.localPosition.y+115,0.6f);
			isMove=true;
			
		}

		if(toggle_FirstNameType.isOn)
			isNormalFirstName=true;
		else
			isNormalFirstName=false;

		toggleGrouplastNameType=toggle_lastNameType.ActiveToggles();
		
		foreach(Toggle item in toggleGrouplastNameType)
		{
			if(item.isOn){
				switch(item.name){
					case "manToggle":
					 lastNameType="boy";
					 break;
					 case "middleToggle":
					 lastNameType="middle";
					break;
					case "wumenToggle":
					lastNameType="girl";
					break;
				}
				//Debug.Log(item.name+lastNameType);
			}			
		}

		toggleGrouplastNameCount=toggle_lastNameCount.ActiveToggles();
		foreach(var item in toggleGrouplastNameCount){
			if(item.isOn)
			{
				switch(item.name){
					case "aloneToggle":
					 lastnameCount=1;
					 break;
					 case "doubleToggle":
					 lastnameCount=2;
					break;
					 case "threeToggle":
					 lastnameCount=3;
					break;
				}
				//Debug.Log(item.name+lastnameCount);
			}
		}
		
	}
	
}
