using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour
{
	public AudioClip intro;
	public float VolumeLowRange;
	public float VolumeHighRange;
	public AudioSource source;

	void Start () 
	{
		float vol = Random.Range (VolumeLowRange, VolumeHighRange);
		source.PlayOneShot(intro, vol);
	}
	

}
