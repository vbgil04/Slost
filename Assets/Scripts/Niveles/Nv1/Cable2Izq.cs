using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable2Izq : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableIzqConectado2 = true;
            Debug.Log("Cable izquierdo 2 conectado");
        }
    }
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableIzqConectado2 = false;
            Debug.Log("Cable izquierdo 2 desconectado");
            slime = null;
        }
    }
}
