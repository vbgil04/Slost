using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class give_gun : MonoBehaviour
{
    // Nombre del prefab de la pistola, que debe estar en la carpeta Resources.
    private string gunPrefabName = "pistola";

    // Parámetros para la pistola.
    private Vector3 gunPosition = new Vector3(0.4925857f, -0.267f, 0.7019545f);
    private Quaternion gunRotation = Quaternion.Euler(0, 90.115f, 0);
    private Vector3 gunScale = new Vector3(3f, 3f, 3f);

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que ha colisionado es el personaje.
        if (other.CompareTag("Player"))
        {
            // Cargar el prefab de la pistola desde Resources.
            GameObject gunPrefab = Resources.Load<GameObject>(gunPrefabName);
            if (gunPrefab != null)
            {
                // Instanciar el prefab.
                GameObject gunInstance = Instantiate(gunPrefab);

                // Buscar el objeto "CamaraPersonaje" en la jerarquía del personaje.
                Transform camaraPersonaje = other.transform.Find("CamaraPersonaje");

                if (camaraPersonaje != null)
                {
                    // Hacer que la pistola sea hija de "CamaraPersonaje".
                    gunInstance.transform.SetParent(camaraPersonaje);

                    // Configurar posición y escala de la pistola.
                    gunInstance.transform.localPosition = gunPosition;
                    gunInstance.transform.localRotation = gunRotation;
                    gunInstance.transform.localScale = gunScale;

                    GlobalVariables.maxSlimes = 1;
                }
                else
                {
                    Debug.LogWarning("No se encontró el objeto CamaraPersonaje en el personaje.");
                }
            }
            else
            {
                Debug.LogError("No se pudo cargar el prefab de la pistola desde Resources.");
            }

            Destroy(gameObject);
        }
    }
}