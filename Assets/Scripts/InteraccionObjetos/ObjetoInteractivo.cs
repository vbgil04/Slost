using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractivo : MonoBehaviour
{
    public Canvas cajaDialogo;
    [SerializeField] private ObjetoDialogo dialogo;
    [SerializeField] private ObjetoDialogo dialogo2;
    private int contador = 0;
    public void ActivarObjeto()
    {
        contador += 1;
        if (contador == 1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo);
        }
        else if (contador>=1)
        {
            cajaDialogo.GetComponent<DialogueUI>().ShowDialogue(dialogo2);
        }
    }
}
