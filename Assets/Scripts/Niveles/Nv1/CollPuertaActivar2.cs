using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollPuertaActivar2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            VariablesGlobalesEventos.jugadorDelantePuerta2 = true;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Player")){
            VariablesGlobalesEventos.jugadorDelantePuerta2 = false;
        }
    }
}
