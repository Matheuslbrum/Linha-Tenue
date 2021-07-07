using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocaloja : MonoBehaviour {
private Rigidbody2D rb;
    public float vel;
    public AudioSource Passo;
    Animator anim;
		
		// Use this for initialization
    void Start ()
    {
		//AnimaçãoLadoEsquedo
			anim = GetComponent<Animator>();
		//AnimaçãoLadoDireito
			rb = GetComponent<Rigidbody2D>();
			
			
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

    public void PassosG()
    {
        Passo.Play();
    }

    void OnTriggerStay2D(Collider2D Colisão)
    {
        if (Colisão.gameObject.tag == "portarua" && Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene("6rua");
			PlayerPrefs.SetInt("cafe", 3);
		
        }
				
    }
}
