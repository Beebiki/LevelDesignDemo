using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
	public float force = 10f;
	
    private void OnTriggerEnter(Collider other)
    {
		
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("collided with player");
			other.GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
			return;
		}
	}
}
