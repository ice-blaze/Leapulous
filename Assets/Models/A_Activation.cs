using UnityEngine;

public abstract class A_Activation : MonoBehaviour
{
	public GameObject form;
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject == form) {
			Execute(collision);
		}
	}

	public abstract void Execute(Collision collision);
}