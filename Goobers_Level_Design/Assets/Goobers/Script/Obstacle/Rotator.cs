using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotationAngle;
    [SerializeField] float rotationSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 
    void FixedUpdate()
    {
        
        Quaternion rotation = Quaternion.Euler(rotationAngle * rotationSpeed);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
