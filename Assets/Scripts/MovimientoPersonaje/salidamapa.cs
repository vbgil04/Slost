using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salidamapa : MonoBehaviour
{
    public GameObject player;
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fueramapa")
        {
           Debug.Log("fuera del mapa");
           player.GetComponent<Player_Move>().HP = 1;
           player.GetComponent<Player_Move>().matarPorCaida();
        }
    }
}
