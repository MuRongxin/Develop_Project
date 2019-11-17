using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignPanle : MonoBehaviour {

	private InputField iniputFirstName;
	private GameObject firstNameType;

	private Button beggin;

	// Use this for initialization
	void Start () {
		iniputFirstName=transform.Find("InputFirstName").GetComponent<InputField>();
		firstNameType=transform.Find("ToggleFirstNameType").gameObject;
		beggin=transform.Find("Beggin").GetComponent<Button>();
		beggin.onClick.AddListener(UIControl._instant.ResoultPanle);
	}
	
	// Update is called once per frame
	void Update () {
		if(iniputFirstName.text=="")
			firstNameType.SetActive(true);
		else
			firstNameType.SetActive(false);
	}
}
