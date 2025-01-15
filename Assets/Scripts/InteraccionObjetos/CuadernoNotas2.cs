using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadernoNotas2 : MonoBehaviour, ObjetosInteractivosInterface
{
    [SerializeField] private ObjetoDialogo cuaderno;
    [SerializeField] private ObjetoDialogo cuaderno2;
    public Canvas cajaDialogo;
    public Material m;

    public void ActivarObjeto()
    {
        if (GlobalVariables.maxSlimes>=5){
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(cuaderno2);
        } else {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(cuaderno);
        }
    }

    public Material GetMaterial()
    {
        return m;
    }
}
