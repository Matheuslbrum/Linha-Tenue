using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class troca : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        StartCoroutine(JumpToScene());


    }
    IEnumerator JumpToScene()
    {
        yield return new WaitForSeconds(9.41f);
        SceneManager.LoadScene("BATIMENTOBOM");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
