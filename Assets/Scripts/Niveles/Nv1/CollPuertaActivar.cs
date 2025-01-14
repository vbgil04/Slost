using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollPuertaActivar : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            VariablesGlobalesEventos.jugadorDelantePuerta = true;
            Debug.Log("jugador delante puerta");
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Player")){
            VariablesGlobalesEventos.jugadorDelantePuerta = false;
        }
    }
}
