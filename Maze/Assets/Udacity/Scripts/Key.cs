using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject door;
	public GameObject keyPoofPrefab;
	public GameObject keyInstance;
	public GameObject directions;


	void Update()
	{
		keyInstance.transform.position = new Vector3 (-11, 2 + (Mathf.PingPong (Time.time, 1)), 11);

	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located, vertically
		Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        
		// Call the Unlock() method on the Door
		var openDoor = door.GetComponent<Door>();
		openDoor.Unlock ();

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(keyInstance);
		Destroy(directions);
    }

}
