using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(menuName = "Dialogue/ObjetoDialogo")]
public class ObjetoDialogo : ScriptableObject
{
    [SerializeField] [TextArea] private string[] burbujasDialogo;
    [SerializeField] private Response[] respuestas;
    public string[] BurbujasDialogo => burbujasDialogo;
    public bool HasResponses => Respuestas.Length > 0 && Respuestas != null;
    public Response[] Respuestas => respuestas;
}

