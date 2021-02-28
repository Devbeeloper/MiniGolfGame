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
            Debug.Log("sek sek sikerek");
            rb.velocity = Vector3.Reflect(rb.velocity, coll.contacts[0].normal);
        }
    }
}
