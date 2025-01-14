using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LadoDerCablesnv1 : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableDerConectado = true;
            Debug.Log("Cable derecho conectado");
        }
    }
    private void Update(){
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableDerConectado = false;
            Debug.Log("Cable derecho desconectado");
            slime = null;
        }
    }
}
