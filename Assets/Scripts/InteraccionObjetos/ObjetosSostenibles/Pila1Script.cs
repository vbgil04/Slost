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
        if (pickUpVariables.isPickedUpPilasnv1_1)
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
        if (other.gameObject.CompareTag("Panel1nv1"))
        {
            VariablesGlobalesEventos.tuberia1eraSalaActiva = true;
            Debug.Log("Tuberia 1era sala activa");
        } else if (other.gameObject.CompareTag("Panel2nv1"))
        {
            VariablesGlobalesEventos.panel2nv1 = true;
            Debug.Log("Panel 2 2da sala activa");
        } else if (other.gameObject.CompareTag("Panel3nv1"))
        {
            VariablesGlobalesEventos.panel3nv1 = true;
            Debug.Log("Panel 3 2da sala activa");
        } else if (other.gameObject.CompareTag("Panel4nv1"))
        {
            VariablesGlobalesEventos.panel4nv1 = true;
            Debug.Log("Panel 4 2da sala activa");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Panel1nv1"))
        {
            VariablesGlobalesEventos.tuberia1eraSalaActiva = false;
            Debug.Log("Tuberia 1era sala desactivada");
        } else if (other.gameObject.CompareTag("Panel2nv1"))
        {
            VariablesGlobalesEventos.panel2nv1 = false;
            Debug.Log("Panel 2 2da sala desactiva");
        } else if (other.gameObject.CompareTag("Panel3nv1"))
        {
            VariablesGlobalesEventos.panel3nv1 = false;
            Debug.Log("Panel 3 2da sala desactiva");
        } else if (other.gameObject.CompareTag("Panel4nv1"))
        {
            VariablesGlobalesEventos.panel4nv1 = false;
            Debug.Log("Panel 4 2da sala desactiva");
        }
    }
    public int GetId()
    {
        return id;
    }
}
