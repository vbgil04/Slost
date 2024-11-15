using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Slime : MonoBehaviour
{
    private bool collisionSlimeS = false;

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.CompareTag("SlimeS") || hit.gameObject.CompareTag("SlimeNoRecogible")) {
            collisionSlimeS = true;
            Debug.Log("Ralentizado");
            GlobalVariables.playerSpeed = 1f;
            GlobalVariables.jumpHeight = 0.3f;
        }
    }

    void Update() {
        Debug.Log(GlobalVariables.maxSlimes);
        if (collisionSlimeS) {
            Debug.Log("Manteniendo ralentización");
            GlobalVariables.slime_collision = true;
        } else {
            Debug.Log("Velocidad normal");
            GlobalVariables.slime_collision = false;
            GlobalVariables.playerSpeed = GlobalVariables.defaultPlayerSpeed;
            GlobalVariables.jumpHeight = GlobalVariables.defaultJumpHeight;
        }
        collisionSlimeS = false;
    }
}
