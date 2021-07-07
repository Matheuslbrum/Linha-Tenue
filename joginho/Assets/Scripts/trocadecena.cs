using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocadecena : MonoBehaviour 
{
    
    Animator anim;
    float PosX, PosY;
    Transform PosButton;
    Vector3 Positions;

    void Start()
    {
       anim = GetComponent<Animator>();
       anim.SetBool("AnimMenu", false);
    }

    void Update () 
	{

    }

	public void OnMouseDown()
	{
        SceneManager.LoadScene("1animinicial");
		PlayerPrefs.SetInt("quarto", 0);
        PlayerPrefs.SetInt("corredor", 0);
        PlayerPrefs.SetInt("destroi_quarto", 0);
        PlayerPrefs.SetInt("destruir_corredor", 0);
        PlayerPrefs.SetInt("destruir_sala", 0);
        PlayerPrefs.SetInt("destruir_cozinha", 0);
		PlayerPrefs.SetInt("destruir_cafe", 0);
        PlayerPrefs.SetInt("destruir_loja", 0);
        PlayerPrefs.SetInt("temporizador", 0);
    }

    public void OnMouseEnter()
    {
            if(anim.GetBool("AnimMenu") == false)
                anim.SetBool("AnimMenu", true);
    }

    void OnMouseExit()
    {
            if(anim.GetBool("AnimMenu") == true)
               anim.SetBool("AnimMenu", false);
    }
	
	
	
	
	
}

 
   