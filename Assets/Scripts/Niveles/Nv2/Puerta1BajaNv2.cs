using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1BajaNv2 : MonoBehaviour
{
    void Update()
    {
        if (VariablesGlobalesEventos.reparar1){
            VariablesGlobalesEventos.puertaQueBaja1salaActivaNv2 = true;
            Destroy(gameObject);
        }
    }
}
