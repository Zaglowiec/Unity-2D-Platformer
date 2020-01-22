using UnityEngine;
using System.Collections;

public class GroundDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//groundDestroy1 = GetComponent<GroundDestroy1>();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player Sword")
		{
			Destroy(gameObject);
		}
	}

}
