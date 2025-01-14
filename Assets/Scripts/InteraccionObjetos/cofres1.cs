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
        GlobalVariables.maxSlimes +=1;
        pared.SetActive(false);
    }
}
