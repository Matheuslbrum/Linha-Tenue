using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ursinho : MonoBehaviour {

    int destroy;

    // Use this for initialization
    void Start () {

        destroy = PlayerPrefs.GetInt("destruir_loja");
        if (destroy == 4)
            gameObject.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
