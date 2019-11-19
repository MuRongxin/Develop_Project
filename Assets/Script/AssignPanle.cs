using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AssignPanle : MonoBehaviour {

	[HideInInspector]
	public static InputField iniputFirstName;
	public static bool isNormalFirstName;
	private GameObject firstNameType;
	private RectTransform toggleMove;
	
	public Toggle toggle_FirstNameType;
	public ToggleGroup toggle_lastNameType;

	public Toggle toggle_lastNameCount;
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

		
	}
	
}
