using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
	void OnTriggerEnter2D()
	{
		Debug.Log("OUT OF BOUNDS!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
