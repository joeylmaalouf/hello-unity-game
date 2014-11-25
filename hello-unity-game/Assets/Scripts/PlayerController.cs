using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public GUIText scoreText;
	public GUIText victoryText;
	private int score;

	void Start()
	{
		this.score = 0;
		this.UpdateText();
		this.victoryText.text = "";
	}

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
		{
			other.gameObject.SetActive(false);
			++this.score;
			this.UpdateText();
		}
	}

	void UpdateText()
	{
		this.scoreText.text = "Score: " + this.score.ToString();
		if (this.score >= 8) this.victoryText.text = "Congratulations!\nYou Win!";
	}
}
