using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour{
	
 //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;
	public GameObject door;
	public static bool keyCollected;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked(){
		
    // Instatiate the KeyPoof Prefab where this key is located
		keyCollected = true;
		Instantiate(KeyPoof,transform.position, Quaternion.Euler (270, 0, 0));
	// Make sure the poof animates vertically
	// Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();
	 // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
	}
}
