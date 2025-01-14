using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 1.5f;
    public GameObject TextDetect;
    GameObject ultimoReconocido = null;
    public Material mat;

    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            if(hit.collider.tag == "Objeto Interactivo")
            {
                if(Input.GetKeyDown(KeyCode.E)){
                    hit.collider.transform.GetComponent<ObjetosInteractivosInterface>().ActivarObjeto();
                }
            }
        }
        else
        {
            Deselect();
        }
    }

    void SelectedObject(Transform transform)
    {
        // transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }

    void Deselect()
    {
        if(ultimoReconocido)
        {
            //change back the material
            // ultimoReconocido.GetComponent<MeshRenderer>().material = ultimoReconocido.GetComponent<ObjetosInteractivosInterface>().GetMaterial();
            ultimoReconocido = null;
        }
    }

    void OnGUI()
    {
        if(ultimoReconocido)
        {
            TextDetect.SetActive(true);
        }
        else
        {
            TextDetect.SetActive(false);
        }
    }
}
