using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoofPrefab;
	public GameObject CoinInstance;

    
	void Update() {
		//rotate coin 180 degrees every second, in world space
		CoinInstance.transform.Rotate (Vector3.up * (Time.deltaTime*180), Space.World);

	}

	public void CoinPoof() 
	{

		// Instantiate the CoinPoof Prefab where this coin is located, vertically
		Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(CoinInstance);
	
	}

}
