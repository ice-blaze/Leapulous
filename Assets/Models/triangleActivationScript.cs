using UnityEngine;
using System.Collections;

public class triangleActivationScript : A_Activation {
	public override void Execute(Collision collision){
		Debug.Log ("suprise motherfucker   "+collision.gameObject.name);
	}
}

