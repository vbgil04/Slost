using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable3Izq : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableIzqConectado3 = true;
            Debug.Log("Cable izquierdo 3 conectado");
        }
    }
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableIzqConectado3 = false;
            Debug.Log("Cable izquierdo 3 desconectado");
            slime = null;
        }
    }
}
