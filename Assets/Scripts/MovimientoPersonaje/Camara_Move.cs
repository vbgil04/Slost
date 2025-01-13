using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara_Move : MonoBehaviour
{
    private float mouseSensitivity = 100f;
    public Transform playerBody;
    private float rotation = 0f;
    public Slider slider;

    

    void Start()
    {
        mouseSensitivity = PlayerPrefs.GetFloat("currentSensitivity", 100);
        slider.value = mouseSensitivity / 10;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        // Obtener la entrada del ratón
        PlayerPrefs.SetFloat("currentSensitivity", mouseSensitivity);
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

    public void AdjustSpeed()
    {
        mouseSensitivity = slider.value * 10;
    }
}
