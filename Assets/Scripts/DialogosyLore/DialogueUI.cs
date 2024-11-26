using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private ObjetoDialogo testDialogue;
    [SerializeField] private GameObject dialoguePanel;
    public float tiempoEntreDialogos = 1f;

    private TypewriterEffect typewriterEffect;
    private ResponseHandler responseHandler;
    
    private void Start() {
        typewriterEffect = GetComponent<TypewriterEffect>();
        responseHandler = GetComponent<ResponseHandler>();
        
        CerrarDialogo();
        ShowDialogue(testDialogue);
    }
    public void ShowDialogue(ObjetoDialogo dialogueObject) {
        dialoguePanel.SetActive(true);
        StartCoroutine( routine: StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(ObjetoDialogo dialogueObject) {
        for (int i = 0; i < dialogueObject.BurbujasDialogo.Length; i++)
        {
            string dialogue = dialogueObject.BurbujasDialogo[i];
            yield return typewriterEffect.Run(dialogue, textLabel);

            if(i == dialogueObject.BurbujasDialogo.Length - 1 && dialogueObject.HasResponses) {
                break;
            }

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0));    
        }
        if(dialogueObject.HasResponses) {
            responseHandler.ShowResponses(dialogueObject.Respuestas);
        } else {
            CerrarDialogo();
        }
    }

    private void CerrarDialogo() {
        dialoguePanel.SetActive(false);
        textLabel.text = string.Empty;
    }
}
