using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public float currentcamera;

	public GameObject rightcamera;
	public GameObject frontcamera;
	public GameObject backcamera;
	public GameObject leftcamera;

	void Start () 
	{
		currentcamera = 1;
	}
	
	// Update is called once per frame

	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.UpArrow))
		{
			currentcamera += 1;
		}
		if (currentcamera >= 5) 
		{
			currentcamera = 1;
		}
		if (Input.GetKeyUp (KeyCode.DownArrow))
		{
			currentcamera -= 1;
		}
		if (currentcamera <= 0) 
		{
			currentcamera = 4;
		}
		if (currentcamera == 1) 
		{
			frontcamera.SetActive (true);
		} 
		else 
		{
			frontcamera.SetActive (false);
		}

		if (currentcamera == 2) 
		{
			leftcamera.SetActive (true);
		}
		else 
		{
			leftcamera.SetActive (false);
		}
		if (currentcamera == 3) 
		{
			backcamera.SetActive (true);
		}
		else 
		{
			backcamera.SetActive (false);
		}
		if (currentcamera == 4) 
		{
			rightcamera.SetActive (true);
		}
		else 
		{
			rightcamera.SetActive (false);
		}
	}
}
//Input.GetKey(KeyCode.Mouse0) 
