using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fimruim : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        StartCoroutine(JumpToScene());


    }
    IEnumerator JumpToScene()
    {
        yield return new WaitForSeconds(6.52f);
        SceneManager.LoadScene("final1");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
