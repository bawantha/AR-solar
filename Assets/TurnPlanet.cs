using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPlanet : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(transform.up*Time.deltaTime*speed);
	}
}
