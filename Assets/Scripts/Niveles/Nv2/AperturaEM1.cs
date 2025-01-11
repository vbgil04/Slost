using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperturaEM1 : MonoBehaviour
{
    public GameObject slimeDeco;
    public GameObject palanca;
    private bool coolConSlime;
    private bool coolConSlime2;
    private GameObject slime;

    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            coolConSlime = false;
            slimeDeco = null;
        }
        coolConSlime2 = palanca.GetComponent<Palancanv2_1>().GetCoolConSlime();
        if (coolConSlime && coolConSlime2){
            Debug.Log("Colision con slime");
            slimeDeco.SetActive(true);
            palanca.GetComponent<Palancanv2_1>().CambiarPos();
            VariablesGlobalesEventos.reparar1 = true;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Colision con slime 1");
        if (collision.gameObject.CompareTag("SlimeR"))
        {
            slime = collision.gameObject;
            coolConSlime = true;
        }
    }
}
