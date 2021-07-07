using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelcod : MonoBehaviour {


[SerializeField]
Text codeText;
string codeTextValue = "";
[SerializeField]
GameObject panel, cofreop, cofreof;

	// Update is called once per frame
	void Update () {
		
		codeText.text = codeTextValue;
		
		if(codeTextValue == "1234")
		{
			cofreof.SetActive(true);
			cofreop.SetActive(false);
			panel.SetActive(false);
			
		}
	if (codeTextValue.Length >= 4)
	{
		codeTextValue = "";
		
	}
	}
	
	public void AddDigit(string digit)
	{
		codeTextValue += digit;
		
	}
	
	
	
	
}



