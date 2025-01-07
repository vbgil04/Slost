using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadernoNotas : MonoBehaviour, ObjetosInteractivosInterface
{
    [SerializeField] private ObjetoDialogo cuaderno;
    public Canvas cajaDialogo;
    public Material m;

    public void ActivarObjeto()
    {
        cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(cuaderno);
    }

    public Material GetMaterial()
    {
        return m;
    }
}
