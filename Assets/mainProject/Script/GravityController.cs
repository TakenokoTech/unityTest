using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

	// 重力加速度
	const float GRAVITY = 9.8F;
	// スケールパラメータ
	public float GRAVITY_SCALE = 1.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 vec = new Vector3 ();

		if (Application.isEditor) {
			vec.x = Input.GetAxis ("Horizontal");
			vec.z = Input.GetAxis ("Vertical");
			vec.y = Input.GetKey ("z") ? 1.0F : -1.0f;
		} else {
			vec.x = Input.acceleration.x;
			vec.y = Input.acceleration.y;
			vec.z = Input.acceleration.z;
		}


		Physics.gravity = GRAVITY * vec.normalized * GRAVITY_SCALE;
	}
}
