using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable3Der : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableDerConectado3 = true;
            Debug.Log("Cable derecho 3 conectado");
        }
    }
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableDerConectado3 = false;
            Debug.Log("Cable derecho 3 desconectado");
            slime = null;
        }
    }
}
