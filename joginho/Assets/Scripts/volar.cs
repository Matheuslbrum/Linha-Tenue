using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class volar : MonoBehaviour {

    public Image memoria1;
    bool []qualquer = new bool[7];
    GameObject quarto, corredor, sala, cozinha, cafe, trabalho;
    private int managerobject = 0;
    public Text textManager;
    public int TesteCamera;
    
	
    float posx = 0f;
    bool funfa;

	// Use this for initialization
	void Start () {
        quarto      = GameObject.FindGameObjectWithTag("lembrança1");
		corredor    = GameObject.FindGameObjectWithTag("lembrança2");
		sala        = GameObject.FindGameObjectWithTag("lembrança4");
	    cozinha     = GameObject.FindGameObjectWithTag("lembrança3");
		cafe        = GameObject.FindGameObjectWithTag("lembrança5");
        trabalho    = GameObject.FindGameObjectWithTag("lembrança7");

        for (int i = 0; i < 7; i++)
			qualquer[i] = false;

        if(PlayerPrefs.GetInt("temporizador") != 30)
            PlayerPrefs.SetInt("temporizador", 0);

        StartCoroutine(ContagemTempo());
	}
	
	// Update is called once per frame
	void Update () {
      
	 	
	
	
        posx = transform.position.x;

        if (Input.GetKeyDown(KeyCode.Space) && memoria1 != null)
		{
			memoria1.gameObject.SetActive(false);
            switch (SceneManager.GetActiveScene().name)
			{
				case "2quarto":
				managerobject = 1;
                    if (posx >= -2.921732f && posx <= -0.6355152f)
                    {
                        if(qualquer[managerobject])
                            Destroy(quarto);
                        qualquer[managerobject] = true;
                    }
				break;
			
			case "3corredor":
			managerobject = 2;
                    if(posx >= 4.11f && posx <= 6.50f)
                    {
                        if (qualquer[managerobject])
                            Destroy(corredor);
                        PlayerPrefs.SetInt("destruir_corredor", 1);
                        qualquer[managerobject] = true;
                    }
			break;
			
			case "4sala":
			managerobject = 3;
                    if (posx >= -16.66f && posx <= -14.39f)
                    {
                        if (qualquer[managerobject])
                            Destroy(sala);
                        PlayerPrefs.SetInt("destruir_sala", 2);
                        qualquer[managerobject] = true;
                    }
			break;
			
			case "5cozinha":
			managerobject = 4;
                    if (posx >= -13.5f && posx <= -11.94f)
                    {
                        if (qualquer[managerobject])
                            Destroy(cozinha);
                        PlayerPrefs.SetInt("destruir_cozinha", 3);
                        qualquer[managerobject] = true;
                    }
			
			break;
			
			case "7cafe":
			managerobject = 5;
                    if(posx >= -15.93f && posx <= -13.51094f)
                    {
                        if (qualquer[managerobject])
                            Destroy(cafe);
                        PlayerPrefs.SetInt("destruir_cafe", 5);
                        qualquer[managerobject] = true;
                    }
			break;

                case "8loja":
                    managerobject = 4;
                    if (posx >= 1.05f && posx <= 3.49f)
                    {
                        if (qualquer[managerobject])
                        {
                            Destroy(trabalho);
                            PlayerPrefs.SetInt("temporizador", 30);
                            //StartCoroutine(ContagemTempo());
                        }
                        PlayerPrefs.SetInt("destruir_loja", 4);
                        qualquer[managerobject] = true;
                    }
             break;
			 
			 
				
			
		
		
	}
		
	}
	}

    IEnumerator ContagemTempo()
    {
        if (textManager != null)
            textManager.text = "";
        if (textManager != null && PlayerPrefs.GetInt("temporizador") != 0)
        {
            for (int i = 30; i > -1; i--)
            {
                PlayerPrefs.SetInt("temporizador", i);
                textManager.text = string.Format("Tempo: {0}", PlayerPrefs.GetInt("temporizador").ToString());
                yield return new WaitForSeconds(1);
            }

            if(PlayerPrefs.GetInt("temporizador") <= 1)
                SceneManager.LoadScene("finalrum");
        
        }
	}
}	