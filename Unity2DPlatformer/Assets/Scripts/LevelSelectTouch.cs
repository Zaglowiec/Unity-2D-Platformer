using UnityEngine;
using System.Collections;

public class LevelSelectTouch : MonoBehaviour {

	public LevelSelectManager theLevelSelectManager;


	// Use this for initialization
	void Start () 
	{
		theLevelSelectManager = FindObjectOfType<LevelSelectManager>();

		theLevelSelectManager.touchMode = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void MoveLeft()
	{
		theLevelSelectManager.positionSelector -= 1;

		if(theLevelSelectManager.positionSelector < 0)
		{
			theLevelSelectManager.positionSelector = 0;
		}
	}

	public void MoveRight()
	{
		theLevelSelectManager.positionSelector += 1;

		if(theLevelSelectManager.positionSelector >= theLevelSelectManager.levelTags.Length)
		{
			theLevelSelectManager.positionSelector = theLevelSelectManager.levelTags.Length - 1;
		}
	}

	public void LoadLevel()
	{
		PlayerPrefs.SetInt("PlayerLevelSelectPosition", theLevelSelectManager.positionSelector);
		Application.LoadLevel(theLevelSelectManager.levelName[theLevelSelectManager.positionSelector]);
	}


}
