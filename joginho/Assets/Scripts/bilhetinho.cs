using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bilhetinho : MonoBehaviour {
    int destroy;

    // Use this for initialization
    void Start () {
        destroy = PlayerPrefs.GetInt("destruir_cozinha");
        if (destroy == 3)
            gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
