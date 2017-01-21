using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
		//loads the maze scene from the start
		SceneManager.LoadScene ("Maze");
	}
}