﻿using UnityEngine;
using System.Collections;

public class LadderZone : MonoBehaviour {

	private PlayerController thePlayer;

	// Use this for initialization
	void Start () 
	{
		thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			thePlayer.onLadder = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			thePlayer.onLadder = false;
		}
	}

}
