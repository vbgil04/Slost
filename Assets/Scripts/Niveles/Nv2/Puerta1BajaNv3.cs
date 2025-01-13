using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1BajaNv2Renamed : MonoBehaviour
{
    void Update()
    {
        if (VariablesGlobalesEventos.reparar2){
            VariablesGlobalesEventos.puertaQueBaja2salaActivaNv2 = true;
            Destroy(gameObject);
        }
    }
}
