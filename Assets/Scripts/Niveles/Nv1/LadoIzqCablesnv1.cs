using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LadoIzqCablesnv1 : MonoBehaviour
{
    private GameObject slime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            slime = other.gameObject;
            VariablesGlobalesEventos.cableIzqConectado = true;
            Debug.Log("Cable izquierdo conectado");
        }
    }
    private void Update(){
        if (slime != null && !slime.activeInHierarchy){
            VariablesGlobalesEventos.cableIzqConectado = false;
            Debug.Log("Cable izquierdo desconectado");
            slime = null;
        }
    }
}
