using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionamientoBalas : MonoBehaviour
{
    public float vida;
    public float nacimiento;
 
    void OnEnable() {
        nacimiento = Time.time; // guardo el tiempo de nacimiento de la bala
    }
    void Update() {
        if(Time.time > nacimiento + vida) { // si el tiempo actual es mayor al tiempo de nacimiento más el tiempo de vida
            gameObject.SetActive(false); // desactivo la bala
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Disparable")) {
            gameObject.SetActive(false); 
            Debug.Log("Bala destruida");

            var slime = PoolManager.Instance.GetSlime();
            if(slime == null ){
                Debug.Log("Max Slimes alcanzado");
                return;
            } 
            ContactPoint contact = collision.GetContact(0);
            slime.transform.position = contact.point;
            slime.transform.rotation = Quaternion.LookRotation(contact.normal);
            slime.SetActive(true);
            GlobalVariables.cantSlimes++;
        } else if (collision.gameObject.CompareTag("SlimeS")) {
            gameObject.SetActive(false);
            Debug.Log("Bala destruida");
        }
    }
}
