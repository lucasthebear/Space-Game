using UnityEngine;
using System.Collections;

public class SimpleAI : MonoBehaviour {
public GameObject Starship;
	public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 StarshipPosition = Starship.transform.position;
		transform.LookAt(StarshipPosition);
		rigidbody.AddForce(transform.forward*Speed*Time.deltaTime);
	}
}
