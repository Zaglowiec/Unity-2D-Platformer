using UnityEngine;
using System.Collections;

public class MovingPlatformSpikes : MonoBehaviour {

	public GameObject platform;

	private float moveSpeed;

	public float MoveSpeed;
	
	public Transform currentPoint;
	
	public Transform[] points;
	
	public int pointSelection;

	public float timeStop;
	private float TimeStop;

	private bool stay;

	private bool firstMove;
	public float firstStay;
	
	// Use this for initialization
	void Start () 
	{
		currentPoint = points[pointSelection];

		TimeStop = timeStop;
		moveSpeed = MoveSpeed;
		stay = false;

		firstMove = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(firstMove)
		{
			if(firstStay > 0)
			{
				firstStay -= Time.deltaTime;
				return;
			}

			else
			firstMove = false;
		}


		platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);
		
		if(platform.transform.position == currentPoint.position)
		{
			stay = true;

			pointSelection++;
			
			if(pointSelection == points.Length)
			{
				pointSelection = 0;
			}
			
			currentPoint = points[pointSelection];
		}

		if(stay)
		{
			if(TimeStop > 0)
			{
				moveSpeed = 0;
				TimeStop -= Time.deltaTime;
			}

			if(TimeStop <= 0)
			{
				moveSpeed = MoveSpeed;
				TimeStop = timeStop;
				stay = false;
			}
		}

	}
}
