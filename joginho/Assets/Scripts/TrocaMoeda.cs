using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaMoeda : MonoBehaviour
{

    public SpriteRenderer spriteR;
    public Sprite newSprite;
    public GameObject moeda;

    // Use this for initialization
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D Colisão)
    {

        if (Colisão.gameObject.tag == "lembrança1" && Input.GetKey(KeyCode.Space))
        {

            spriteR.sprite = newSprite;

        }


        }
}

