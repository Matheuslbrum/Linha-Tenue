using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour 
{
	public Transform player;

	float posx;

	void Start () 
	{
			
	}
	
	void Update () 
	{
        posx = player.position.x;
		transform.position = new Vector3(posx,7,-10);
	}
}
