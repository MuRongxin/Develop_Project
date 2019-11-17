using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AssignPanle : MonoBehaviour {

	private InputField iniputFirstName;
	private GameObject firstNameType;
	private RectTransform toggleMove;
	private RectTransform initPos;
	private bool isMove;

	private Button beggin;

	// Use this for initialization
	void Start () {
		iniputFirstName=transform.Find("InputFirstName").GetComponent<InputField>();
		firstNameType=transform.Find("ToggleFirstNameType").gameObject;
		beggin=transform.Find("ToggleMove/Beggin").GetComponent<Button>();
		toggleMove=transform.Find("ToggleMove").GetComponent<RectTransform>();
		beggin.onClick.AddListener(UIControl._instant.ResoultPanle);
		initPos=toggleMove;
	}
	
	// Update is called once per frame
	void Update () {
		if(iniputFirstName.text=="")
		{
			firstNameType.SetActive(true);
			if(isMove==true)
				toggleMove.DOLocalMoveY(toggleMove.localPosition.y-115,0.6f);
			isMove=false;
		}
		else
		{
			firstNameType.SetActive(false);
			if(!isMove)
				toggleMove.DOLocalMoveY(toggleMove.localPosition.y+115,0.6f);
			isMove=true;
			
		}
	}
}
