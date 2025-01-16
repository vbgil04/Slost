using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMeh : MonoBehaviour, ObjetosInteractivosInterface
{
    private int random = 0;
   public void ActivarObjeto()
    {
        if (GlobalVariables.maxSlimes>=4)
        {
            random = Random.Range(0, 2);
            if (random == 0)
            {
                SceneManager.LoadScene("Final3");
            }
            else
            {
                SceneManager.LoadScene("Final2");
            }
        }
    }

    public Material GetMaterial()
    {
        return null;
    }
}
