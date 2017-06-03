using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

	public string activeTag;

	void OnTriggerStay (Collider other) {
		Rigidbody r = other.gameObject.GetComponent<Rigidbody> ();
		Vector3 dir = transform.position - other.gameObject.transform.position;
		dir.Normalize ();

		if (other.gameObject.tag == activeTag) {
			r.velocity *= 9.0F;
			r.AddForce (dir * r.mass * 20.0F);
		} else {
			r.AddForce (-dir * r.mass * 80.0F);
		}
	} 
}
