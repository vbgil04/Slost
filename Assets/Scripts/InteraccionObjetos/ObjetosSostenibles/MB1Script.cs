using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB1Script : MonoBehaviour, ObjetosSosteniblesInterface
{
    public const int id = 1;
    private Rigidbody rb;
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
        // if (rb == null)
        // {
        //     Debug.LogError("No Rigidbody component found on this GameObject.");
        // }
    }
    void Update()
    {
        if (pickUpVariables.isPickedUpMBnv1_1)
        {
            if (rb != null)
            {
                rb.isKinematic = true;
                // Debug.Log("Rigidbody deactivated.");
            }
        } else {
            if (rb != null)
            {
                rb.isKinematic = false;
                // Debug.Log("Rigidbody activated.");
            }
        }
    }
    public int GetId()
    {
        return id;
    }
}
