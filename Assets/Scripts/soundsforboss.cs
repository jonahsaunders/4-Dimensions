using UnityEngine;
using System.Collections;

public class soundsforboss : MonoBehaviour 
{
	public float play;
	public AudioClip defeat;
	public float VolumeLowRange;
	public float VolumeHighRange;
	public AudioSource source;


	void Update ()
	{
		if (play == 1) 
		{
			play += 1;
			float vol = Random.Range (VolumeLowRange, VolumeHighRange);
			source.PlayOneShot(defeat, vol);
		}
	}
}
//soundwall
//GameObject.Find("soundwall").GetComponent<BossBattle>().health -= 1;
