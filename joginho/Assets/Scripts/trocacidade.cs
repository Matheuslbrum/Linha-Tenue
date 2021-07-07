using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocacidade : MonoBehaviour {
    private Rigidbody2D rb;
    public float vel;
    public AudioSource Passo;
    Animator anim;
	public int corredor, cafe, loja, temporizador; 
	private string sceneName;
	
    // Use this for initialization
    void Start()
    {
		cafe = PlayerPrefs.GetInt("cafe");
        //AnimaçãoLadoEsquedo
        anim = GetComponent<Animator>();
        //AnimaçãoLadoDireito
        rb = GetComponent<Rigidbody2D>();
		
		    GameObject corredor_pos = GameObject.Find("portacorredor");
			GameObject cafe_pos = GameObject.Find("portacafe");
			GameObject loja_pos = GameObject.Find("portaloja");
			
			
			Scene scene = SceneManager.GetActiveScene();
			sceneName = scene.name;
			
			
				if(sceneName == "6rua")
			{
				if(cafe == 1)   gameObject.transform.position = corredor_pos.transform.position;
				if(cafe == 2)	gameObject.transform.position = cafe_pos.transform.position;
				if(cafe == 3)	gameObject.transform.position = loja_pos.transform.position;
				
				
			
				
			}
    }

    // Update is called once per frame

    // MovimentaçãoComAnimação

    void Update()
    {
		float x = Input.GetAxis("Horizontal") * vel;
        rb.velocity = new Vector2(x, 0);

        if (x > 0)
            Flip();
        if (x < 0)
        {
            Vector3 PosPlayer = transform.localScale;
            PosPlayer.x = 17.19116f;
            transform.localScale = PosPlayer;
        }
        if (x != 0)
            anim.SetBool("parado", true);
        else
            anim.SetBool("parado", false);
    }
    //TrocaPos
    void Flip()
    {
        Vector3 PosPlayer = transform.localScale;
        PosPlayer.x = -17.1911f;
        transform.localScale = PosPlayer;
    }
	
	  void OnTriggerStay2D(Collider2D Colisão)
    {
        if (Colisão.gameObject.tag == "portacorredor1" && Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene("3corredor");
			PlayerPrefs.SetInt("quarto", 4);
        }
		
		if (Colisão.gameObject.tag == "portacafe" && Input.GetKey(KeyCode.Space))
		{
		SceneManager.LoadScene("7cafe");
		}
		
	     if (Colisão.gameObject.tag == "portaloja" && Input.GetKey(KeyCode.Space))
		 {
	     SceneManager.LoadScene("8loja");
		 }
    }


    public void PassosG()
    {
        Passo.Play();
    }
}
