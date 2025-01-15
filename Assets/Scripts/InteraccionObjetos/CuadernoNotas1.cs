using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadernoNotas1 : MonoBehaviour, ObjetosInteractivosInterface
{
    [SerializeField] private ObjetoDialogo cuaderno;
    public Canvas cajaDialogo;
    public Material m;

    public void ActivarObjeto()
    {
        VariablesGlobalesEventos.CuadernoNotas1 = true;
        VariablesGlobalesEventos.contSal1 = 0;
        cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(cuaderno);
    }

    public Material GetMaterial()
    {
        return m;
    }
}
