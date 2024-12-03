using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable4Izq : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableIzqConectado4 = true;
            Debug.Log("Cable izquierdo 4 conectado");
        }
    }
    
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableIzqConectado4 = false;
            Debug.Log("Cable izquierdo 4 desconectado");
            slime = null;
        }
    }
}
