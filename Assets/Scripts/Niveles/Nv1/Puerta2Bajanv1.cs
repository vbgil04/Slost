using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2Bajanv1 : MonoBehaviour
{
    void Update(){
        if(VariablesGlobalesEventos.cableIzqConectado2 && VariablesGlobalesEventos.cableDerConectado2 && VariablesGlobalesEventos.panel2nv1 
            && VariablesGlobalesEventos.panel4nv1 && VariablesGlobalesEventos.cableDerConectado4 && VariablesGlobalesEventos.cableIzqConectado4 
            && (VariablesGlobalesEventos.tiempoCable4conectado<VariablesGlobalesEventos.tiempoCable2conectado ) 
            && VariablesGlobalesEventos.tiempoCable2conectado!=0 && VariablesGlobalesEventos.tiempoCable4conectado!=0 
            && VariablesGlobalesEventos.jugadorDelantePuerta2
            && !(VariablesGlobalesEventos.cableIzqConectado3 && VariablesGlobalesEventos.cableDerConectado3 && VariablesGlobalesEventos.panel3nv1)){
            VariablesGlobalesEventos.puertaQueBaja2salaActiva = true;
            VariablesGlobalesEventos.contSalomon = 0;
            Destroy(gameObject);
        } else if (VariablesGlobalesEventos.puertaQueBaja2salaActiva){
            Destroy(gameObject);
        }
    }
}
