using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable4Der : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableDerConectado4 = true;
            VariablesGlobalesEventos.tiempoCable4conectado = Time.time;
            Debug.Log("Cable derecho 4 conectado");
        }
    }
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableDerConectado4 = false;
            VariablesGlobalesEventos.tiempoCable4conectado = 0;
            Debug.Log("Cable derecho 4 desconectado");
            slime = null;
        }
    }
}
