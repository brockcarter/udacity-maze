using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public Animator doorOpen;
	bool locked = true; 

    
	void Start() {
		doorOpen.StartPlayback();
	}
	
	void Update() 
	{
        // If the door is unlocked and it is not fully raised
		if (locked == false){
			// Animate the door raising up
			//Debug.Log("This is set to activate door anim.");
			doorOpen.StopPlayback();

		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
			locked = false;
    }
}
