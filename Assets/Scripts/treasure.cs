using UnityEngine;
using System.Collections;

public class treasure : MonoBehaviour 
{

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			GameObject.Find("bossenemy").GetComponent<BossBattle>().health -= 1;
			Destroy (this.gameObject.gameObject);
		}
	}
}
