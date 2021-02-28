using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    RaycastHit objectHit;

   

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out objectHit, Mathf.Infinity))
            {
                if(objectHit.collider.gameObject.tag == "Ball")
                {
                    Debug.Log("Topa Tıkladın laaan");
                    Debug.Log(objectHit.transform.position);
                }
            }
        }
    }
}
