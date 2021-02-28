using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public float speed = 10;
    public float maxSpeed = 100;

    private Rigidbody rb;
    bool isBallClicked = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

   

        if (Input.GetMouseButtonDown(0))
        {

            

            RaycastHit objectHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out objectHit, Mathf.Infinity))
            {
                if(objectHit.collider.gameObject.tag == "Ball")
                { 

                    isBallClicked = true;
                }
            }
        }





        if (Input.GetMouseButtonUp(0))
        {
            if (isBallClicked)
            {
                Vector3 worldPosition = getWorldPosition();
                isBallClicked = false;
                Debug.Log(worldPosition);
                Vector3 newVelocity = (this.transform.position - worldPosition) * speed;
                if (newVelocity.magnitude > maxSpeed)
                {
                    newVelocity = newVelocity.normalized * maxSpeed;
                }
                newVelocity.y = 0.0f;

                rb.velocity = newVelocity;
            }
            
        }

    }


    private Vector3 getWorldPosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit ,Mathf.Infinity))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
}


