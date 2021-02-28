using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friction : MonoBehaviour
{
    public float friction = 0.6f;
    public float gravityScale = 10;

    Rigidbody rb;

    private bool onGround;


   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 frictionForce;
        frictionForce = -(rb.velocity.normalized * rb.mass * friction * gravityScale);

        if (rb.velocity.magnitude != 0)
        {
            
            rb.AddForce(frictionForce);
        }
    }
}
