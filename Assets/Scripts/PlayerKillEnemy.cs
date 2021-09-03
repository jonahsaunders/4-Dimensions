using UnityEngine;
using System.Collections;

public class PlayerKillEnemy : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Spot")
		{
			Destroy(other.gameObject);
		}
	}
}
