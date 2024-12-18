using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RalentizacionSLime : MonoBehaviour
{
    private bool collisionSlime = false;

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.CompareTag("SlimeR")||hit.gameObject.CompareTag("SlimeNoRecogible")) {
            collisionSlime = true;
            // Debug.Log("Ralentizado");
            GlobalVariables.playerSpeed = 1f;
            GlobalVariables.jumpHeight = 0.3f;
        }
    }

    void Update() {
        if (collisionSlime) {
            // Debug.Log("Manteniendo ralentización");
            GlobalVariables.slime_collision = true;
        } else {
            // Debug.Log("Velocidad normal");
            GlobalVariables.slime_collision = false;
            GlobalVariables.playerSpeed = GlobalVariables.defaultPlayerSpeed;
            GlobalVariables.jumpHeight = GlobalVariables.defaultJumpHeight;
        }
        collisionSlime = false;
    }
}
