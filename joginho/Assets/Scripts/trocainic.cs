using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocainic : MonoBehaviour {

	// Use this for initialization
	void Start () 
		{
		
		StartCoroutine (JumpToScene());
		}
		
		IEnumerator JumpToScene()
		{
		yield return new WaitForSeconds (15.50f);
		SceneManager.LoadScene("2quarto");
		PlayerPrefs.SetInt("corredor", 2);
		}
		
	// Update is called once per frame
	  void Update () {
		  if(Input.GetKey(KeyCode.Space))
		SceneManager.LoadScene("2quarto");
	}
}
