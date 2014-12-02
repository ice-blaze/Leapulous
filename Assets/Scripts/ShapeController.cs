using UnityEngine;
using System.Collections;

public class ShapeController : MonoBehaviour {

	private Vector3 initPosition;
	private Vector3 initVelocity;

	// Use this for initialization
	void Start () {
		initPosition = transform.position;
		initVelocity = rigidbody.velocity;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "FallDetection") {
			transform.position = initPosition;
			rigidbody.velocity = initVelocity;
		}
		if (collider.gameObject.tag == "Goal") {
			Debug.Log("Got it");
			gameObject.SetActive(false);
		}
	}
}
