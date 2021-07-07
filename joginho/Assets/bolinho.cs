using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinho : MonoBehaviour {

    int destroy;

    // Use this for initialization
    void Start () {


        destroy = PlayerPrefs.GetInt("destruir_cafe");
        if (destroy == 5)
            gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
