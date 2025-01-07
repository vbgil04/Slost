using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salomon : MonoBehaviour, ObjetosInteractivosInterface
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    [SerializeField] private ObjetoDialogo dialogo3;
    [SerializeField] private ObjetoDialogo dialogo4;
    [SerializeField] private ObjetoDialogo dialogo5;
    [SerializeField] private ObjetoDialogo dialogo6;
    
    public Material m;
    private bool aux = true;
    private bool aux2 = true;
    void Update()
    {
        if (VariablesGlobalesEventos.puertaQueBaja1salaActiva && aux)
        {
            VariablesGlobalesEventos.contSalomon = 0;
            aux = false;
        }
        if (VariablesGlobalesEventos.puertaQueBaja2salaActiva && aux2)
        {
            VariablesGlobalesEventos.contSalomon  = 0;
            aux2 = false;
        }

    }
    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.contSalomon  += 1;
        if (!VariablesGlobalesEventos.puertaQueBaja1salaActiva && VariablesGlobalesEventos.contSalomon  == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (!VariablesGlobalesEventos.puertaQueBaja1salaActiva && VariablesGlobalesEventos.contSalomon >=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        } 
        else if (VariablesGlobalesEventos.puertaQueBaja1salaActiva && !VariablesGlobalesEventos.puertaQueBaja2salaActiva && VariablesGlobalesEventos.contSalomon  == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo3);
        }
        else if(VariablesGlobalesEventos.puertaQueBaja1salaActiva && !VariablesGlobalesEventos.puertaQueBaja2salaActiva && VariablesGlobalesEventos.contSalomon  >= 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo4);
        }
        else if (VariablesGlobalesEventos.puertaQueBaja2salaActiva && VariablesGlobalesEventos.contSalomon  == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo5);
        } 
        else if (VariablesGlobalesEventos.puertaQueBaja2salaActiva && VariablesGlobalesEventos.contSalomon  >= 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo6);
        }
    }

    public Material GetMaterial()
    {
        return m;
    }
}
