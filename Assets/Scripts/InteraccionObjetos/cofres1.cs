using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofres1 : MonoBehaviour, ObjetosInteractivosInterface
{
    public GameObject pared;
    public Material GetMaterial()
    {
        return null;
    }

    public void ActivarObjeto()
    {
        if (!VariablesGlobalesEventos.cf2){
            GlobalVariables.maxSlimes +=1;
            VariablesGlobalesEventos.cf2 = true;
            pared.SetActive(false);
        }
    }
}
