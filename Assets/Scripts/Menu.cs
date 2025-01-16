using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar() // este método carga la escena del juego desde el menú de inicio
    {
        ReinicioMuerte reinicioMuerte = new ReinicioMuerte();
        reinicioMuerte.InicioMenu();
        SceneManager.LoadScene("CinematicaInicio");
    }
    public void Salir() // este método cierra la aplicación desde el menú de inicio
    {
        Application.Quit();
    }
}