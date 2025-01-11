using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar() // este método carga la escena del juego desde el menú de inicio
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Salir() // este método cierra la aplicación desde el menú de inicio
    {
        Application.Quit();
    }
}