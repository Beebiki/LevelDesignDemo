using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region SerializedField
    [SerializeField] float moveSpeed;

    #endregion

    #region Private Variables
    Rigidbody rb;
    float h, v;
    #endregion
    void Start()
    {
         rb = GetComponentInChildren<Rigidbody>();
    }
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(h, 0, v).normalized;
        if(movement.magnitude >= .1f)
        {
            rb.velocity = movement * moveSpeed;
        }
    }
}
