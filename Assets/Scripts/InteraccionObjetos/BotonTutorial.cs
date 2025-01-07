using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTutorial : MonoBehaviour, ObjetosInteractivosInterface
{
    [SerializeField] private ObjetoDialogo dialogo;
    public Canvas cajaDialogo;
    public Material m;

    public void ActivarObjeto()
    {
        cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
    }

    public Material GetMaterial()
    {
        return m;
    }
}
