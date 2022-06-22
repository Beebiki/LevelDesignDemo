using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
	public float force = 10f; //Force 10000f
	private Vector3 hitDir;

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Player")
			{
				Debug.Log("collided with player");
				hitDir = contact.normal;
                collision.rigidbody.AddForce(-hitDir * force,ForceMode.Impulse);
                return;
              
                
			}
		}
	}
}
