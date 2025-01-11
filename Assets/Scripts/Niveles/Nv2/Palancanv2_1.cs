using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palancanv2_1 : MonoBehaviour
{
    private bool coolConSlime = false;
    private GameObject slime;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SlimeR"))
        {
            slime = other.gameObject;
            coolConSlime = true;
        }
    }

    private void Update() {
        if (slime != null && !slime.activeInHierarchy){
            coolConSlime = true;
            slime = null;
        }
    }

    public bool GetCoolConSlime()
    {
        return coolConSlime;
    }
    public void CambiarPos(){
        transform.position = new Vector3(-0.651f, 0.49060f, -48.833f);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        gameObject.tag = "Untagged";
        if (gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.isKinematic = true;
        }
    }
}
