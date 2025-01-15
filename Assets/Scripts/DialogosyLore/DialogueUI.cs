using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    // [SerializeField] private ObjetoDialogo testDialogue;
    [SerializeField] private GameObject dialoguePanel;
    public float tiempoEntreDialogos = 1f;

    private TypewriterEffect typewriterEffect;
    private ResponseHandler responseHandler;
    public GameObject player;
    public GameObject pistola;
    public Camera camara;
    
    private void Start() {
        typewriterEffect = GetComponent<TypewriterEffect>();
        responseHandler = GetComponent<ResponseHandler>();
        
        CerrarDialogo();
        // ShowDialogue(testDialogue);
    }
    public void ShowDialogue(ObjetoDialogo dialogueObject) {
        Debug.Log("D0");
        player.GetComponent<Player_Move>().enabled = false;
        camara.GetComponent<Camara_Move>().enabled = false;
        camara.GetComponent<Selected>().enabled = false;
        pistola.GetComponent<FuncionamientoPistola>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        dialoguePanel.SetActive(true);
        StartCoroutine(routine: StepThroughDialogue(dialogueObject));
    }

    public IEnumerator StepThroughDialogue(ObjetoDialogo dialogueObject) {
        for (int i = 0; i < dialogueObject.BurbujasDialogo.Length; i++)
        {
            Debug.Log("D1");
            string dialogue = dialogueObject.BurbujasDialogo[i];
            yield return typewriterEffect.Run(dialogue, textLabel);
            Debug.Log("D2");
            if(i == dialogueObject.BurbujasDialogo.Length - 1 && dialogueObject.HasResponses) {
                break;
            }
            Debug.Log("D3");
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0));    
        }
        if(dialogueObject.HasResponses) {
            responseHandler.ShowResponses(dialogueObject.Respuestas);
        } else {
            CerrarDialogo();
        }
    }

    public void CerrarDialogo() {
        Debug.Log("D4");
        dialoguePanel.SetActive(false);
        player.GetComponent<Player_Move>().enabled = true;
        camara.GetComponent<Camara_Move>().enabled = true;
        camara.GetComponent<Selected>().enabled = true;
        pistola.GetComponent<FuncionamientoPistola>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        textLabel.text = string.Empty;
        Debug.Log("D5");
    }
}
