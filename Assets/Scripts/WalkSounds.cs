using UnityEngine;
using System.Collections;

public class WalkSounds : MonoBehaviour 
{
	public GameObject walksounds;

	public AudioClip jump;

	public float VolumeLowRange;

	public float VolumeHighRange;

	public AudioSource source;

	private bool nojumpsound;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			StartCoroutine("Jump");

		}
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.A) || (Input.GetKeyDown (KeyCode.S) || (Input.GetKeyDown (KeyCode.D))))
		{
			StartCoroutine("SoundOn");
		} 
	}
	IEnumerator SoundOn ()
	{
		walksounds.SetActive (true);
		yield return new WaitForSeconds(4);
		walksounds.SetActive (false);
	}
	IEnumerator Jump ()
	{
		if (nojumpsound == false)
		{
			nojumpsound = true;
			float vol = Random.Range (VolumeLowRange, VolumeHighRange);
			source.PlayOneShot(jump, vol);
			yield return new WaitForSeconds(3);
			nojumpsound = false;
		}
	}
}
