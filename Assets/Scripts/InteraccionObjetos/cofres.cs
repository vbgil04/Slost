using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofres : MonoBehaviour, ObjetosInteractivosInterface
{
    public GameObject animacionDeCofre;
    private Animator animator;
    void Start()
    {
        animator = animacionDeCofre.GetComponent<Animator>();
    }
    public Material GetMaterial()
    {
        return null;
    }

    public void ActivarObjeto()
    {
        if (!VariablesGlobalesEventos.cf1){
            GlobalVariables.maxSlimes +=1;
            VariablesGlobalesEventos.cf1 = true;
            VariablesGlobalesEventos.contSalomon1 = 0;
        }
        
    }
}
