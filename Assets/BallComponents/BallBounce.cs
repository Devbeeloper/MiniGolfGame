using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    Rigidbody rb;
    Vector3 comingDirection;
    public float bounceMultiplier = 0.8f;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        comingDirection = rb.velocity;
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Bouncable")
        {
            Vector3 normal = coll.contacts[0].normal;
            Vector3 bounceDirection = Vector3.Reflect(comingDirection, normal);

            rb.velocity = bounceDirection * bounceMultiplier;
        }
    }
}
