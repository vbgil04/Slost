using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Move : MonoBehaviour
{
    private float mouseSensitivity = 300f;
    public Transform playerBody;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Obtener la entrada del ratón
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Controlar la rotación vertical (cámara)
        mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Limita la rotación para evitar voltear la cámara

        // Aplicar rotación a la cámara y al jugador
        transform.localRotation = Quaternion.Euler(-mouseY, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
