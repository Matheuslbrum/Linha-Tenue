using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantinha : MonoBehaviour {

    int destroy;
	// Use this for initialization
	void Start () {
        destroy = PlayerPrefs.GetInt("destruir_corredor");
        if (destroy == 1)
            gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
