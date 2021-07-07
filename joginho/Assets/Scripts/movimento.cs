using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movimento : MonoBehaviour
{
    public GameObject memoria;
    private Rigidbody2D rb;
		public float vel;
        
        Animator anim;
		int quarto, cozinha, sala, destroy, rua;
		private string sceneName;
		public Text NewText;

		
    // Use this for initialization
    void Start ()
    {
		NewText.text = string.Empty;
			GameObject cozinha_pos = GameObject.Find("coz_pos");
			GameObject quarto_pos = GameObject.Find("sala_pos");
			GameObject sala_pos = GameObject.Find("quarto_pos");
			GameObject rua_pos = GameObject.Find("rua_pos");
			
			quarto = PlayerPrefs.GetInt("quarto");
		//AnimaçãoLadoEsquedo
			anim = GetComponent<Animator>();
		//AnimaçãoLadoDireito
			rb = GetComponent<Rigidbody2D>();
			
			Scene scene = SceneManager.GetActiveScene();
			sceneName = scene.name;
			
			if(sceneName == "3corredor")
			{
				if(quarto == 1) gameObject.transform.position = quarto_pos.transform.position;
				if(quarto == 2)	gameObject.transform.position = cozinha_pos.transform.position;
				if(quarto == 3)	gameObject.transform.position = sala_pos.transform.position;
				if(quarto == 4) gameObject.transform.position = rua_pos.transform.position;
				
			}

      

    }
	
	// Update is called once per frame
	
	// MovimentaçãoComAnimação
	
	void Update () 
    {  
		float x = Input.GetAxis("Horizontal") * vel;
		rb.velocity = new Vector2(x,0);
		
		if(x > 0)
			Flip();
		if(x < 0)
		{
			Vector3 PosPlayer = transform.localScale;
			PosPlayer.x = 3.0f;
			transform.localScale = PosPlayer;
		}
		if(x != 0)
			anim.SetBool("parado", true);
		else
			anim.SetBool("parado", false);


        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("0menu");
        }

    }
	   //TrocaPos
		void Flip()
		{
			Vector3 PosPlayer = transform.localScale;
			PosPlayer.x = -3.0f;
			transform.localScale = PosPlayer;
		}
        



    void OnTriggerStay2D(Collider2D Colisão)	{
			if (Colisão.gameObject.tag == "portaquarto" && Input.GetKey(KeyCode.Space)) 
			{
			  SceneManager.LoadScene("2quarto");
			  PlayerPrefs.SetInt("corredor", 1);
				
			}
			//	if (Colisão.gameObject.tag == "portasala" && Input.GetKey(KeyCode.Space))
				//SceneManager.LoadScene("4sala");
				
				if (Colisão.gameObject.tag == "portacozinha" && Input.GetKey(KeyCode.Space))
				SceneManager.LoadScene("5cozinha");

        if (Colisão.gameObject.tag == "portarua" && Input.GetKey(KeyCode.Space))
		{
            SceneManager.LoadScene("6rua");
		    PlayerPrefs.SetInt("cafe", 1);
		}
		if (Colisão.gameObject.tag == "portasala" && Input.GetKey(KeyCode.Space))
		{
			NewText.text = "O cômodo não está disponivel para essa demo.";
		}
       
    }

    



}











