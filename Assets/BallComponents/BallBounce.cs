using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Bouncable")
        {
            Vector3 normal = coll.contacts[0].normal.normalized;
            float velocityMagnitude = rb.velocity.magnitude;
            Vector3 comingDirection = rb.velocity.normalized;
            Vector3 bounceDirection = (comingDirection + (2 * normal)).normalized;
            rb.velocity = bounceDirection * velocityMagnitude;
        }
    }
}
