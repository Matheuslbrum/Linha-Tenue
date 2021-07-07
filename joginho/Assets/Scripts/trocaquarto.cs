using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class trocaquarto : MonoBehaviour {

    public GameObject memoria;
       private Rigidbody2D rb;
	   public float vel;
       public AudioSource Passo;
       Animator anim;
	   int corredor,anima, destroy;
		private string sceneName;
       bool Cheking = true;
	   float x;
	  
      [SerializeField]
	 GameObject cofreop, cofreof, Panel2;
		
	
		
    // Use this for initialization
    void Start ()
    {
		
		
		   cofreof.SetActive(false);
		   cofreop.SetActive(true);
		
		
		    GameObject corredor_pos = GameObject.Find("quart_pos");
			GameObject anima_pos = GameObject.Find("anima_pos");

            destroy = PlayerPrefs.GetInt("destroi_quarto");
            if (destroy == 1) Destroy(memoria);
            corredor = PlayerPrefs.GetInt("corredor");
		
		//AnimaçãoLadoEsquedo
			anim = GetComponent<Animator>();
		//AnimaçãoLadoDireito
			rb = GetComponent<Rigidbody2D>();
			
			Scene scene = SceneManager.GetActiveScene();
			sceneName = scene.name;
		
			if(sceneName == "2quarto")
			{
				if(corredor == 1) gameObject.transform.position = corredor_pos.transform.position;
				if(corredor == 2)	gameObject.transform.position = anima_pos.transform.position;
			
			}

	}
	
	// Update is called once per frame
	
	// MovimentaçãoComAnimação
	
	void Update () 
    {
            if(Cheking)
			{
			 x = Input.GetAxis("Horizontal") * vel;
            rb.velocity = new Vector2(x, 0);

            if (x > 0)
                Flip();
            if (x < 0)
            {
                Vector3 PosPlayer = transform.localScale;
                PosPlayer.x = 3.0f;
                transform.localScale = PosPlayer;
            }
            if (x != 0)
                anim.SetBool("parado", true);
            else
                anim.SetBool("parado", false);
			}

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
			if (Colisão.gameObject.tag == "portacorredor1" && Input.GetKey(KeyCode.Space)){
                PlayerPrefs.SetInt("destroi_quarto", 1);

                SceneManager.LoadScene("3corredor");
				PlayerPrefs.SetInt("quarto", 3);
			}
			if (Colisão.gameObject.tag == "puzzle1" && Input.GetKey(KeyCode.Space))
			{
			  
			  cofreop.SetActive(true);
			  Panel2.SetActive(true); 
				//Cheking = false;
				//rb.velocity = new Vector3(0,0,0);
				}
			
			
		
			
			
			
		}

    public void PassosG()
    {
        Passo.Play();
    }

}