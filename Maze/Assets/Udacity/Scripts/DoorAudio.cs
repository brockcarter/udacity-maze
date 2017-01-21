using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudio : MonoBehaviour 
{
    //Create a reference to the DoorAudioPrefab
	public GameObject DoorAudioPrefab;

    public void DoorAud() 
	{

		// Instantiate the prefab for audio
		Instantiate(DoorAudioPrefab, transform.position, transform.rotation);

	
	}

}
