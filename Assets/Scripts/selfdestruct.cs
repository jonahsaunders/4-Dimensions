using UnityEngine;
using System.Collections;

public class selfdestruct : MonoBehaviour 
{


	void Start () 
	{
		Destroy (this.gameObject, 10);
	}
	

}
