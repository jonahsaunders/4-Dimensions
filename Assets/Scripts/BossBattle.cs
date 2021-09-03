using UnityEngine;
using System.Collections;

public class BossBattle : MonoBehaviour
{

	public GameObject enemytospawn;
	public GameObject spawnenemypoint;
	public GameObject fightone;
	public GameObject fighttwo;
	public GameObject fightthree;
	public GameObject fightfour;
	public GameObject fire;
	public float range;
	public float phase;
	private int random;
	public GameObject player;
	public float health;
	public bool done;

	public AudioClip defeat;
	public float VolumeLowRange;
	public float VolumeHighRange;
	public AudioSource source;

	void Start () 
	{
		player = GameObject.FindWithTag("Player");
		phase = 1;
		health = 2;
		done = false;
		StartCoroutine("SpawnEnemy");
	}
	void Update ()
	{
		if (health <= 0) 
		{
			GameObject.Find("soundwall").GetComponent<soundsforboss>().play += 1;
			if (done = false) 
			{
				done = true;
				float vol = Random.Range (VolumeLowRange, VolumeHighRange);
				source.PlayOneShot(defeat, vol);
			}
			Destroy (this.gameObject);
		}
		if (health == 1) 
		{
			phase = 2;
		}
	}
	IEnumerator SpawnEnemy ()
	{
		if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < range)
		{
			if (phase == 1)
			{
				fire.SetActive (false);
				GameObject enemy = Instantiate (enemytospawn) as GameObject;
				enemy.transform.position = spawnenemypoint.transform.position;
			}
			if (phase == 2) 
			{
				fire.SetActive (true);
				int random = Random.Range (0, 6);
					if (random == 1)
					{
						fightone.SetActive (true);
						fighttwo.SetActive (false);
						fightthree.SetActive (false);
						fightfour.SetActive (false);
					}
					if (random == 2)
					{
						fightone.SetActive (false);
						fighttwo.SetActive (true);
						fightthree.SetActive (false);
						fightfour.SetActive (false);
					}
					if (random == 3)
					{
						fightone.SetActive (false);
						fighttwo.SetActive (false);
						fightthree.SetActive (true);
						fightfour.SetActive (false);
					}
					if (random == 4)
					{
						fightone.SetActive (false);
						fighttwo.SetActive (false);
						fightthree.SetActive (true);
						fightfour.SetActive (false);
					}
					if (random == 5)
					{
						fightone.SetActive (true);
						fighttwo.SetActive (true);
						fightthree.SetActive (true);
						fightfour.SetActive (true);
					}
			}
		}
		yield return new WaitForSeconds(4);
		StartCoroutine("SpawnEnemy");
	}

}
