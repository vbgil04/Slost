using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila1Script : MonoBehaviour, ObjetosSosteniblesInterface
{
    public const int id = 2;
    private Rigidbody rb;
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (pickUpVariables.isPickedUpPilanv1_1)
        {
            if (rb != null)
            {
                rb.isKinematic = true;
            }
        } else {
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Panelnv1"))
        {
            VariablesGlobalesEventos.tuberia1eraSalaActiva = true;
            Debug.Log("Tuberia 1era sala activa");
        }
    }
    public int GetId()
    {
        return id;
    }
}
