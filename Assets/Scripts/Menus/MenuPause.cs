using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject panelPausa; // panel de pausa
    public static bool pausado = false; // variable para saber si el juego está pausado
    void Start()
    {
        panelPausa.SetActive(false); // desactivo el panel de pausa al inicio
    }
    void OnLoad()
    {
        panelPausa.SetActive(false); // desactivo el panel de pausa al inicio
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){ // si se presiona la tecla E
            if (pausado){ // si el juego está pausado lo reanudo, si no lo pauso
                Reanudar();
            } else {
                Pausar();
            }
        }
    }
    public void Pausar(){ 
        Time.timeScale = 0f; // pauso el tiempo
        panelPausa.SetActive(true); // activo el panel de pausa
        pausado = true; // cambio la variable de pausa a verdadero
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Reanudar(){
        Time.timeScale = 1f; // reanudo el tiempo
        panelPausa.SetActive(false); // desactivo el panel de pausa
        pausado = false; // cambio la variable de pausa a falso
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void MenuPrinc(){
        Time.timeScale = 1f;
        panelPausa.SetActive(false); // desactivo el panel de pausa
        SceneManager.LoadScene("Inicio");
    }
    public void Reload(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tutorial");
        panelPausa.SetActive(false); // desactivo el panel de pausa
    }
}
