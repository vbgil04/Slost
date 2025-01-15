using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salazarNV1 : MonoBehaviour, ObjetosInteractivosInterface
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    [SerializeField] private ObjetoDialogo dialogo3;
    [SerializeField] private ObjetoDialogo dialogo4;
    
    public Material m;
    void Update()
    {

    }
    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.contSal1  += 1;
        if (VariablesGlobalesEventos.contSal1  == 1)
        {
            if (VariablesGlobalesEventos.CuadernoNotas1)
            {
               cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
            }
            else
            {
                cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo4);
            }
        }
        else if (VariablesGlobalesEventos.contSal1 >=1)
        {
            if(VariablesGlobalesEventos.CuadernoNotas1)
            {
                cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
            }
            else
            {
                cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo3);
            }
        } 
        
    }

    public Material GetMaterial()
    {
        return m;
    }
}
