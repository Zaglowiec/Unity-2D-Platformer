using UnityEngine;
using System.Collections;

public class GroundDeleteTime : MonoBehaviour {

	public float deleteTime;
	public float respawnTime;

	private bool isground;

	// Use this for initialization
	void Start () 
	{
		isground = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name == "HeadStomper")
		{
			if(isground == true)
			{
		
				StartCoroutine("DeleteGround");
				Debug.Log("Dalej");
				isground = false;
			}
		}
	}

	public IEnumerator DeleteGround()
	{

		yield return new WaitForSeconds(deleteTime);
		enabled = false;
		GetComponent<Renderer>().enabled = false;
		GetComponent<BoxCollider2D>().enabled = false;

		yield return new WaitForSeconds(respawnTime);

		enabled = true;
		GetComponent<Renderer>().enabled = true;
		GetComponent<BoxCollider2D>().enabled = true;
		isground = true;
	}

}
