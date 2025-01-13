using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarPistola : MonoBehaviour
{
    public GameObject pistola;
    public GameObject prop;
    public GameObject canvasmira;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pistola.SetActive(true);
            prop.SetActive(false);
            canvasmira.SetActive(true);
            Destroy(gameObject);
        }
    }
}
