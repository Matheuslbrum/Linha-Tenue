using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlar : MonoBehaviour
{

    int fim = 0;
    public GameObject fim2;
   // public Transform lbFinal;
	bool[] qualquer = new bool[5];
    GameObject quarto;
    GameObject corredor;
    GameObject sala;
    GameObject cozinha;

    int managerobject = 0;
    bool CanPause = true;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        quarto = GameObject.FindGameObjectWithTag("lembrança1");
        corredor = GameObject.FindGameObjectWithTag("lembrança2");
        sala = GameObject.FindGameObjectWithTag("lembrança4");
        cozinha = GameObject.FindGameObjectWithTag("lembrança3");
        for (int i = 0; i < 5; i++)
            qualquer[i] = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(fim < 5)
	//		lbFinal.position = new Vector3(1000,-1000,1000);
		//else if(fim > 5)
			//lbFinal.position = new Vector3(-76.6f,114.5f,0);
		//pause
        if (Input.GetKeyDown("p"))
        {
            if (CanPause)
            {
                Debug.Log("pause");
                Time.timeScale = 0;
                CanPause = false;
            }
            else
            {
                Time.timeScale = 1;
                CanPause = true;
            }

            //menu
           
              

            switch (SceneManager.GetActiveScene().name)
            {
                case "2quarto":
                    managerobject = 1;
                    if (quarto == null && !qualquer[managerobject])
                    {
                        fim += 1;
                        Debug.Log("vai krl" + SceneManager.GetActiveScene().name);
                        qualquer[managerobject] = !qualquer[managerobject];
                    }
                    break;

                case "3corredor":
                    managerobject = 2;
                    if (corredor == null && !qualquer[managerobject])
                    {
                        fim += 1;
                        Debug.Log("vai krl" + SceneManager.GetActiveScene().name);
                        qualquer[managerobject] = !qualquer[managerobject];
                    }
                    break;

                case "4sala":
                    managerobject = 3;
                    if (sala == null && !qualquer[managerobject])
                    {
                        fim += 1;
                        Debug.Log("vai krl");
                        qualquer[managerobject] = !qualquer[managerobject];
                    }

                    break;

                case "5cozinha":
                    managerobject = 4;
                    if (cozinha == null && !qualquer[managerobject])
                    {
                        fim += 1;
                        Debug.Log("vai krl" + SceneManager.GetActiveScene().name);
                        qualquer[managerobject] = !qualquer[managerobject];
                    }
                    break;




            }
        }
    }
}
