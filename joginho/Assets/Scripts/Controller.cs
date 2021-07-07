using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    public static Vector3 lastPoint = new Vector3();
    public static string lastLevel = "";

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);        
        if (lastLevel.Equals("3corredor"))
        {
            GameObject.FindWithTag("player").transform.position = lastPoint;            
        }
    }


  
}
