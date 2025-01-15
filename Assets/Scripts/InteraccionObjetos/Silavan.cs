using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silavan : MonoBehaviour, ObjetosInteractivosInterface
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    [SerializeField] private ObjetoDialogo trespts;
    
    public Material m;
    void Update()
    {

    }
    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.contSilS1  += 1;
        if (VariablesGlobalesEventos.contSilS1  == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (VariablesGlobalesEventos.contSilS1 >=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        } else {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(trespts);
        }
        
    }

    public Material GetMaterial()
    {
        return m;
    }
}
