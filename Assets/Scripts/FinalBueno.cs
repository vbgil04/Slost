using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBueno : MonoBehaviour, ObjetosInteractivosInterface
{
    public void ActivarObjeto()
    {
        if (GlobalVariables.maxSlimes>=5)
        {
            SceneManager.LoadScene("Final1");
        }
    }

    public Material GetMaterial()
    {
        return null;
    }
}
