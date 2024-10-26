using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Slime : MonoBehaviour
{
    private bool collisionSlimeS = false;

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.CompareTag("SlimeS")) {
            collisionSlimeS = true;
            Debug.Log("Ralentizado");
            GlobalVariables.playerSpeed = 1f;
            GlobalVariables.jumpHeight = 0.3f;
        }
    }

    void Update() {
        if (collisionSlimeS) {
            Debug.Log("Manteniendo ralentización");
        } else {
            Debug.Log("Velocidad normal");
            GlobalVariables.playerSpeed = GlobalVariables.defaultPlayerSpeed;
            GlobalVariables.jumpHeight = GlobalVariables.defaultJumpHeight;
        }
        collisionSlimeS = false;
    }
}
