﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookCamera : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
	}
}
