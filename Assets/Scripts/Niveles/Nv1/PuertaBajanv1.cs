using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaBajanv1 : MonoBehaviour
{
    void Update(){
        if(VariablesGlobalesEventos.cableIzqConectado && VariablesGlobalesEventos.cableDerConectado && VariablesGlobalesEventos.tuberia1eraSalaActiva){
            VariablesGlobalesEventos.puertaQueBaja1salaActiva = true;
            Destroy(gameObject);
        }
    }
}
