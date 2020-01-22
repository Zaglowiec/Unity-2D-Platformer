using UnityEngine;
using System.Collections;

public class YouWin : MonoBehaviour {

	public float timeWin;
	public string level;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(timeWin > 0)
		{
			timeWin -= Time.deltaTime;
			return;
		}

		if(Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(level);
		}
	}
}
