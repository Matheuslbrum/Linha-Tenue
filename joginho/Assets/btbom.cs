using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btbom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(JumpToScene());
    }

    IEnumerator JumpToScene()
    {
        yield return new WaitForSeconds(8.90f);
        SceneManager.LoadScene("final2");

    }



    // Update is called once per frame
    void Update () {
        
    }
}
