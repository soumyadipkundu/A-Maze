using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    // Create a boolean value called "locked" that can be checked in Update()
	bool locked= true;
	bool raiseDoor;
	public AudioClip doorLocked;
	public AudioClip doorOpened;
	public AudioSource doorSoundPlayer;

	void Start(){
		doorSoundPlayer = GetComponent<AudioSource>();
	}

	 void Update(){
		// If the door is unlocked and it is not fully raised

		if (!locked && raiseDoor) {
			if (transform.position.y < 27f) {
				transform.Translate (0, 15f * Time.deltaTime, 0, Space.World);
			}
		}
			
	}
		public void Unlock(){
		//You will need to set "locked" to true here! 
		locked = false;
	}

		public void DoorStatus(){
		if (Key.keyCollected && transform.position.y < 27f) {
			raiseDoor = true;
			doorSoundPlayer.clip = doorOpened;
			doorSoundPlayer.Play ();
	} else {
			doorSoundPlayer.clip = doorLocked;
			doorSoundPlayer.Play();
		}
	}

}



