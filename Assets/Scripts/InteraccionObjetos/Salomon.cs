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
    private int contador = 0;
    private bool aux = true;
    private bool aux2 = true;
    void Update()
    {
        if (VariablesGlobalesEventos.puertaQueBaja1salaActiva && aux)
        {
            contador = 0;
            aux = false;
        }

    }
    public void ActivarObjeto()
    {
        contador += 1;
        if (!VariablesGlobalesEventos.puertaQueBaja1salaActiva && contador == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (!VariablesGlobalesEventos.puertaQueBaja1salaActiva && contador>=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        } 
        else if (VariablesGlobalesEventos.puertaQueBaja1salaActiva && !VariablesGlobalesEventos.puertaQueBaja2salaActiva && contador == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo3);
        }
        else if(VariablesGlobalesEventos.puertaQueBaja1salaActiva && !VariablesGlobalesEventos.puertaQueBaja2salaActiva && contador >= 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo4);
        }
    }
}
