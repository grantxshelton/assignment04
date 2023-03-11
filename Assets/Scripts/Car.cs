using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;
	public GameObject carObj;

	public float minSpeed = 8f;
	public static float maxSpeed = 12f;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
		Invoke("Destroy", 10.0f); //Destroys the cars after 10 seconds to reduce resources.
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

	void Destroy()
    {
		Destroy(carObj);
    }

}
