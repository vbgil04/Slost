using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salomon2 : MonoBehaviour, ObjetosInteractivosInterface
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    [SerializeField] private ObjetoDialogo dialogo3;
    [SerializeField] private ObjetoDialogo treptos;
    
    public Material m;
    void Update()
    {

    }
    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.contSalomon2  += 1;
        if (!VariablesGlobalesEventos.cf1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (VariablesGlobalesEventos.cf1 && !VariablesGlobalesEventos.cf2)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        } 
        else if (VariablesGlobalesEventos.cf2)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo3);
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
