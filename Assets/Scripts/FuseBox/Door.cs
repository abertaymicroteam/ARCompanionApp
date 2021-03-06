﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	//Door states
	public enum DoorState {open,closed};	//possible door states
	[Tooltip("Current state of the door ( Open or Closed)")]		
	public DoorState doorState;				//current state of the door

	//Rotation management variables	
	[Tooltip("How long will it take to rotate?")]
	public float rotationTime;	//how long does it take to rotate?

	void Start () {
		//Start the game with the door closed 
		doorState = DoorState.closed;
	}

	/// <summary>
	/// Update the door
	/// </summary>
	void Update () {
		rotateDoor ();
	}

	/// <summary>
	/// Checks the current DoorState and rotates the door accordingly.
	/// </summary>
	private void rotateDoor(){

		//Closed door
		if (doorState == DoorState.closed) {
			if (transform.rotation.eulerAngles.y < 0|| transform.rotation.eulerAngles.y > 230) {

			transform.Rotate (new Vector3 (0, rotationTime * 120 * Time.deltaTime , 0));
			}
		}
		//Open door
		if (doorState == DoorState.open) {
			if (transform.rotation.eulerAngles.y < 10  || transform.rotation.eulerAngles.y > 240) {

				transform.Rotate (new Vector3 (0,-rotationTime * 120 * Time.deltaTime , 0));
			}
		}
			
	}

	/// <summary>
	/// Changes the DoorState to open or closed.
	/// </summary>
	public void useDoor(){
		
		if (doorState == DoorState.open) {
			doorState = DoorState.closed;
		}

		else if (doorState == DoorState.closed) {
			doorState = DoorState.open;

		}
	}


}
