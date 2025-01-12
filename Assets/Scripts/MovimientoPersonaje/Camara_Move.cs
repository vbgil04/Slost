using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Move : MonoBehaviour
{
    private float mouseSensitivity = 300f;
    public Transform playerBody;
    private float rotation = 0f;

    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        // Obtener la entrada del ratón
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Acumular la rotación vertical y limitarla
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);

        // Aplicar la rotación acumulada a la cámara
        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);

        // Rotar el cuerpo del jugador en el eje Y
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
