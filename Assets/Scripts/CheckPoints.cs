using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckPoints : MonoBehaviour 
{


	public GameObject[] checkpoint;

	public int currentcheckpoint;

	public Text deathone;
	public Text deathtwo;
	public Text deaththree;
	public Text deathfour;

	public float deaths;


	void Update ()
	{
		deathone.text = "Deaths: " + deaths.ToString();
		deathtwo.text = "Deaths: " + deaths.ToString();
		deaththree.text = "Deaths: " + deaths.ToString();
		deathfour.text = "Deaths: " + deaths.ToString();
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Death")
		{
			deaths += 1;
			this.gameObject.transform.position = checkpoint [currentcheckpoint].transform.position;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Checkpoint")
		{
			currentcheckpoint += 1;
			Destroy (other.gameObject);
		}
	}
}
