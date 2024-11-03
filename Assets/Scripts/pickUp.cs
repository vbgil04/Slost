using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public float pickUpRange = 20f;
    public Transform holdingPosition;
    private GameObject heldObject;
    private bool isHolding = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isHolding)
            {
                ReleaseObject();
            }
            else
            {
                TryPickUpObject();
            }
        }
    }

    void TryPickUpObject()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pickUpRange)) // El out es un puntero
        {
            if (hit.collider.CompareTag("cogible"))
            {
                heldObject = hit.collider.gameObject;
                heldObject.transform.position = holdingPosition.position;
                heldObject.transform.parent = holdingPosition;
                isHolding = true;
            }
        }
    }

    void ReleaseObject()
    {
        if (heldObject != null)
        {
            heldObject.transform.parent = null;
            isHolding = false;
            heldObject = null;
        }
    }
}