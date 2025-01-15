using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salomon1 : MonoBehaviour, ObjetosInteractivosInterface
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    [SerializeField] private ObjetoDialogo dialogo3;
    [SerializeField] private ObjetoDialogo dialogo4;
    [SerializeField] private ObjetoDialogo dialogo5;
    [SerializeField] private ObjetoDialogo dialogo6;
    [SerializeField] private ObjetoDialogo treptos;
    
    public Material m;
    void Update()
    {

    }
    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.contSalomon1  += 1;
        if (!VariablesGlobalesEventos.cf1 && !VariablesGlobalesEventos.cf2 && VariablesGlobalesEventos.contSalomon1  == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (!VariablesGlobalesEventos.cf1 && !VariablesGlobalesEventos.cf2 && VariablesGlobalesEventos.contSalomon1 >=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        } 
        else if (VariablesGlobalesEventos.cf1 && !VariablesGlobalesEventos.cf2 && VariablesGlobalesEventos.contSalomon1 ==1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo3);
        } 
        else if (VariablesGlobalesEventos.cf1 && !VariablesGlobalesEventos.cf2 && VariablesGlobalesEventos.contSalomon1 >=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo4);
        } 
        else if (!VariablesGlobalesEventos.cf1 && VariablesGlobalesEventos.cf2){
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo5);
        } 
        else if (VariablesGlobalesEventos.cf1 && VariablesGlobalesEventos.cf2){
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo6);
        }
        else {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(treptos);
        }
    }

    public Material GetMaterial()
    {
        return m;
    }
}
