using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {

   bool CanPause = true;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown ("p")) {
         if(CanPause)
         {
             Debug.Log("pause");
             Time.timeScale=0;
             CanPause = false;
         }
         else
         {
             Time.timeScale=1;
             CanPause=true;
         }
		
     }
	  
	}
}
