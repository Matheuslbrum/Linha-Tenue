using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PegarItem : MonoBehaviour {

  
	public Image memoria1;
    public SpriteRenderer spriteR;
    public Sprite newSprite;
	public Text NewText;
	public bool TextAvailable;
	private bool textAvailable2 = false;
    int cor;

    // Use this for initialization
    void Start () {

        PlayerPrefs.SetInt("mudar_cor", 0);
        cor = PlayerPrefs.GetInt("mudar_cor");
        spriteR = gameObject.GetComponent<SpriteRenderer>();
		
    }

    // Update is called once per frame
	
	IEnumerator TimeRemaining()
	{
		yield return new WaitForSeconds(1);
		textAvailable2 = true;
	}
	
    void Update () {
		if(Input.GetKey(KeyCode.Space) && textAvailable2)
		{
			NewText.text 	= string.Empty;
			textAvailable2 	= false;
		}
		
	}
	
	//lembrança game
	void OnTriggerStay2D(Collider2D Colisão)
	{
        if (Colisão.gameObject.tag == "lembrança1" && Input.GetKey(KeyCode.Space))
        {
            memoria1.gameObject.SetActive(true);
            //cor++;
            PlayerPrefs.SetInt("mudar_cor", 1);
       }

        if (Colisão.gameObject.tag == "lembrança2" && Input.GetKey(KeyCode.Space))
        {
            
            Controller.lastPoint = transform.position;            
           memoria1.gameObject.SetActive(true);
        }

        if (Colisão.gameObject.tag == "lembrança3" && Input.GetKey(KeyCode.Space))
        {
            memoria1.gameObject.SetActive(true);
        }

        if (Colisão.gameObject.tag == "lembrança4" && Input.GetKey(KeyCode.Space))
        {
            memoria1.gameObject.SetActive(true);
        }

        if (Colisão.gameObject.tag == "lembrança5" && Input.GetKey(KeyCode.Space))
        {
            memoria1.gameObject.SetActive(true);
        }
		
		if (Colisão.gameObject.tag == "lembrança7" && Input.GetKey(KeyCode.Space))
			memoria1.gameObject.SetActive(true);

        if (Colisão.gameObject.tag == "lembrança4" && Input.GetKey(KeyCode.Space))
        {
            memoria1.gameObject.SetActive(true);
        }

        if (Colisão.gameObject.tag == "lembrançafinal" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("finalbom");
        }
       


		if (Colisão.gameObject.tag == "portasinuteis" && Input.GetKey(KeyCode.Space))
        {
			print("work");
			if(TextAvailable && !textAvailable2)
			{
				NewText.text = "Porta trancada.Vou tentar outras!";
				StartCoroutine(TimeRemaining());
			}
        }
		
				
	




    }
	
    
	
	
	
}
