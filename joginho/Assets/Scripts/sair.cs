using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sair : MonoBehaviour {

	[SerializeField]
	GameObject Panel;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void Onclick ()
	{
		Panel.SetActive(false);
		
	}
	
	
}
