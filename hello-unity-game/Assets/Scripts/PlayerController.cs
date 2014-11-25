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
    rigidbody.AddForce(movement * speed * Time.deltaTime);
  }
}
