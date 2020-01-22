﻿using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;

	public AudioSource coinSoundEffect;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.GetComponent<PlayerController>() == null)
			return;

		ScoreManger.AddPoints(pointsToAdd);

		coinSoundEffect.Play();

		Destroy(gameObject);
	}
}
