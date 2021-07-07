using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portinha : MonoBehaviour {

    int destroy;

    // Use this for initialization
    void Start () {
        destroy = PlayerPrefs.GetInt("destruir_sala");
        if (destroy == 2)
            gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
