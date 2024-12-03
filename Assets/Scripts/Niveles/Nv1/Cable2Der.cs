using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable2Der : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableDerConectado2 = true;
            VariablesGlobalesEventos.tiempoCable2conectado = Time.time;
            Debug.Log("Cable derecho 2 conectado");
        }
    }
    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableDerConectado2 = false;
            VariablesGlobalesEventos.tiempoCable2conectado = 0;
            Debug.Log("Cable derecho 2 desconectado");
            slime = null;
        }
    }
}
