using UnityEngine;
using System.Collections;

public class PlayerMovements : MonoBehaviour {

	public float speed;
	public float sprintSpeed;
	public float jumpForce;
	public float gravity;

	private CharacterController cc;
	private Vector3 moveDirection;


	void Start()
	{
		cc = GetComponent<CharacterController>();
		moveDirection = new Vector3();
	}

	void Update()
	{
		if (cc.isGrounded) {

			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);

			if(Input.GetKey(KeyCode.LeftShift))
				moveDirection *= sprintSpeed;
			else
				moveDirection *= speed;

			if (Input.GetButton("Jump"))
				moveDirection.y = jumpForce;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		cc.Move(moveDirection * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Speedy")
		{
			StartCoroutine("Speedy");
		}
		if(other.gameObject.tag == "Jumpy")
		{
			StartCoroutine("Jumpy");
		}
	}
	IEnumerator Speedy ()
	{
		speed = 12;
		sprintSpeed = 18;
		yield return new WaitForSeconds(4);
		speed = 3;
		sprintSpeed = 9;
	}
	IEnumerator Jumpy ()
	{
		jumpForce = 40;
		yield return new WaitForSeconds(4);
		jumpForce = 15;

	}
}
