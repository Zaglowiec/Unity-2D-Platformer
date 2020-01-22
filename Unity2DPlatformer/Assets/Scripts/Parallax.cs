using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	public Transform[] backgounds;
	private float[] parallaxScales;
	public float smoothing;

	private Transform cam;
	private Vector3 previousCamPos;

	// Use this for initialization
	void Start () 
	{
		cam = Camera.main.transform;

		previousCamPos = cam.position;

		parallaxScales = new float [backgounds.Length];

		for(int i = 0; i< backgounds.Length; i++)
		{
			parallaxScales[i] = backgounds[i].position.z * -1;
		}
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		for(int i = 0; i < backgounds.Length; i++)
		{
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

			float backgroundTargetPosX = backgounds[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgounds[i].position.y, backgounds[i].position.z);

			backgounds[i].position = Vector3.Lerp( backgounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);

		}

		previousCamPos = cam.position;

	}


}
