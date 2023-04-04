using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if(!other.gameObject.CompareTag("Farmer"))
		{
			Points.instance.AddPoint();
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		else
		{
			Points.instance.DecreaseLives();

			Destroy(gameObject);
			Destroy(other.gameObject);
			//Debug.Log("Game Over");
		}
		
	}
}
