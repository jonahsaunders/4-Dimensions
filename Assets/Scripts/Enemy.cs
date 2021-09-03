using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{

	public GameObject player;
	public GameObject deathspot;
	public float distance;
	public float speed;

	void Start ()
	{
		StartCoroutine("Hunt");
		player = GameObject.FindWithTag("Player");
	}
	void Update ()
	{
		if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < distance)
		{
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
	}


	

	IEnumerator Hunt ()
	{
		yield return new WaitForSeconds(2);
		if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < distance)
		{
			transform.LookAt(player.transform);
		}
		StartCoroutine("Hunt");
	}
}
