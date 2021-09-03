using UnityEngine;
using System.Collections;

public class PlaySoundDestroy : MonoBehaviour
{
	public AudioClip sound;
	public float VolumeLowRange;
	public float VolumeHighRange;
	public AudioSource source;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			float vol = Random.Range (VolumeLowRange, VolumeHighRange);
			source.PlayOneShot(sound, vol);
			Destroy (this.gameObject);
		}
	}
}
