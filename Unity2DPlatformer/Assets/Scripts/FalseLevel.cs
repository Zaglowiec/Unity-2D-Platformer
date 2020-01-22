using UnityEngine;
using System.Collections;

public class FalseLevel : MonoBehaviour {

	public bool playerInZone;

	public GameObject ground;
	
	// Use this for initialization
	void Start () 
	{
		playerInZone = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		//if(Input.GetKeyDown(KeyCode.W) && playerInZone)
		if(Input.GetAxisRaw("Vertical") > 0 && playerInZone)
		{
			DeleteEver();
		}
	}
	
	public void DeleteEver()
	{
		Destroy(ground);
		Destroy(gameObject);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			playerInZone = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			playerInZone = false;
		}
	}
	
}
