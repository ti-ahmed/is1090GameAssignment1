﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (15, 30, 45);
		transform.Rotate (rotation * Time.deltaTime);
	}
}
