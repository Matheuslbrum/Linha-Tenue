using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mudar_cor : MonoBehaviour {

    public Sprite cor_inicial, cor_changed;
    public int valor_da_cor;
    int mudar_Cor;

	void Start ()
    {
        DontDestroyOnLoad(this);
        //mudar_Cor = PlayerPrefs.GetInt("mudar_cor");
	}
	
	void Update ()
    {
        mudar_Cor = PlayerPrefs.GetInt("mudar_cor");
        if (mudar_Cor >= valor_da_cor)
        {
            GetComponent<SpriteRenderer>().sprite = cor_changed;
        }
	}
}
