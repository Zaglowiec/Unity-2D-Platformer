﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

	public static int score;

	Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();

		//score = 0;

		score = PlayerPrefs.GetInt("CurrentPlayerScore");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(score <0)
			score = 0;

		text.text = "" + score;
	}

	public static void AddPoints (int pointsToAdd)
	{
		score += pointsToAdd;
		PlayerPrefs.SetInt("CurrentPlayerScore", score);
	}

	public static void Reset()
	{
		score = 0;
		PlayerPrefs.SetInt("CurrentPlayerScore", score);
	}

}
