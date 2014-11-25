using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	void FixedUpdate()
	{
		Vector3 movement = new Vector3
		(
			Input.GetAxis("Horizontal"),
			0.0f,
			Input.GetAxis("Vertical")
		);

		this.rigidbody.AddForce(movement * this.speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
			other.gameObject.SetActive(false);
	}
}
