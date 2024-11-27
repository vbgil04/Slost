using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LadoDerCablesnv1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SlimeR")){
            VariablesGlobalesEventos.cableDerConectado = true;
        }
    }
}
