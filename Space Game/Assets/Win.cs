﻿using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
void OnTriggerEnter(Collider other){

		if(other.tag == "Player" ){
			Application.LoadLevel("level2");

		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

