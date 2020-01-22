using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public int healthToGive;

	public AudioSource pickupSound;

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

		HeatltManager.HurtPlayer(-healthToGive);

		pickupSound.Play();
		
		Destroy(gameObject);
	}

}
