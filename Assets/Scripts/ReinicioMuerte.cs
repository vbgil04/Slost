using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinicioMuerte : MonoBehaviour
{
    public void RestReinicioMuerte(){
        VariablesGlobalesEventos.CuadernoNotas1 = false;
         VariablesGlobalesEventos.cableIzqConectado = false;
         VariablesGlobalesEventos.cableDerConectado = false;
         VariablesGlobalesEventos.tuberia1eraSalaActiva = false;
         VariablesGlobalesEventos.jugadorDelantePuerta = false;
        VariablesGlobalesEventos.puertaQueBaja1salaActiva = false;
         VariablesGlobalesEventos.cableIzqConectado2 = false;
         VariablesGlobalesEventos.cableDerConectado2 = false;
         VariablesGlobalesEventos.cableIzqConectado3 = false;
         VariablesGlobalesEventos.cableDerConectado3 = false;
         VariablesGlobalesEventos.cableIzqConectado4 = false;
         VariablesGlobalesEventos.cableDerConectado4 = false;
        VariablesGlobalesEventos.tiempoCable2conectado = 0;
        VariablesGlobalesEventos.tiempoCable4conectado = 0;
         VariablesGlobalesEventos.panel2nv1 = false;
         VariablesGlobalesEventos.panel3nv1 = false;
         VariablesGlobalesEventos.panel4nv1 = false;
         VariablesGlobalesEventos.jugadorDelantePuerta2 = false;
     VariablesGlobalesEventos.puertaQueBaja2salaActiva = false;

     VariablesGlobalesEventos.reparar1 = false;
     VariablesGlobalesEventos.reparar2 = false;
     VariablesGlobalesEventos.puertaQueBaja1salaActivaNv2 = false;
     VariablesGlobalesEventos.puertaQueBaja2salaActivaNv2 = false;

    //(cofres)
    if (VariablesGlobalesEventos.cf1){
         VariablesGlobalesEventos.puertaQueBaja1salaActiva = true;
          VariablesGlobalesEventos.puertaQueBaja2salaActiva = true;
    }

    if (VariablesGlobalesEventos.cf2){
         VariablesGlobalesEventos.puertaQueBaja1salaActivaNv2 = true;
          VariablesGlobalesEventos.puertaQueBaja2salaActivaNv2 = true;
    }
    }
    public void InicioMenu(){
        VariablesGlobalesEventos.CuadernoNotas1 = false;
         VariablesGlobalesEventos.cableIzqConectado = false;
         VariablesGlobalesEventos.cableDerConectado = false;
         VariablesGlobalesEventos.tuberia1eraSalaActiva = false;
         VariablesGlobalesEventos.jugadorDelantePuerta = false;
        VariablesGlobalesEventos.puertaQueBaja1salaActiva = false;
         VariablesGlobalesEventos.cableIzqConectado2 = false;
         VariablesGlobalesEventos.cableDerConectado2 = false;
         VariablesGlobalesEventos.cableIzqConectado3 = false;
         VariablesGlobalesEventos.cableDerConectado3 = false;
         VariablesGlobalesEventos.cableIzqConectado4 = false;
         VariablesGlobalesEventos.cableDerConectado4 = false;
        VariablesGlobalesEventos.tiempoCable2conectado = 0;
        VariablesGlobalesEventos.tiempoCable4conectado = 0;
         VariablesGlobalesEventos.panel2nv1 = false;
         VariablesGlobalesEventos.panel3nv1 = false;
         VariablesGlobalesEventos.panel4nv1 = false;
         VariablesGlobalesEventos.jugadorDelantePuerta2 = false;
     VariablesGlobalesEventos.puertaQueBaja2salaActiva = false;

     VariablesGlobalesEventos.reparar1 = false;
     VariablesGlobalesEventos.reparar2 = false;
     VariablesGlobalesEventos.puertaQueBaja1salaActivaNv2 = false;
     VariablesGlobalesEventos.puertaQueBaja2salaActivaNv2 = false;

     VariablesGlobalesEventos.cf1 = false;
        VariablesGlobalesEventos.cf2 = false;
         VariablesGlobalesEventos.contSalomon1 = 0;
         VariablesGlobalesEventos.contSalomon2 = 0;
         VariablesGlobalesEventos.contSalomon = 0;
         VariablesGlobalesEventos.contSilS1 = 0;
         VariablesGlobalesEventos.contSal1 = 0;
         VariablesGlobalesEventos.conSaloTuto = 0;
         GlobalVariables.cantSlimes = 0; 
    GlobalVariables.maxSlimes = 3;
    GlobalVariables.playerSpeed = 8f;
    GlobalVariables.defaultPlayerSpeed = 8f;
   GlobalVariables.slime_collision = false;

    GlobalVariables.jumpHeight = 1f;
    GlobalVariables.defaultJumpHeight = 1f;
    }
}
