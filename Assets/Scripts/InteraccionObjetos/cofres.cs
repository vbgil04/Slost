using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofres : MonoBehaviour, ObjetosInteractivosInterface
{
    public Material GetMaterial()
    {
        return null;
    }

    public void ActivarObjeto()
    {
        GlobalVariables.maxSlimes +=1;
        this.enabled = false;
    }
}
