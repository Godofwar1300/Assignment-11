using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : MonoBehaviour {

/*
		 * (Christopher Green)
		 * (ObstacleAnimation)
		 * (Assignment 11)
		 * (This script handles movement and animation of the obstacles)
*/

    public float speed = .2f;
	public float strength = 9f;

	private float randomOffset;

	// Use this for initialization
	void Start () {
		randomOffset = Random.Range(0f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
		transform.position = pos;
	}
}
