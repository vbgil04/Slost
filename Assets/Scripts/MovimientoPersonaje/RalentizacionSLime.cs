using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RalentizacionSLime : MonoBehaviour
{
    private bool collisionSlime = false;
    public GameObject player;

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.CompareTag("SlimeR")||hit.gameObject.CompareTag("SlimeNoRecogible")||hit.gameObject.CompareTag("silavandano")) {
            collisionSlime = true;
            // Debug.Log("Ralentizado");
            GlobalVariables.playerSpeed = 1f;
            GlobalVariables.jumpHeight = 0.3f;
            if (hit.gameObject.CompareTag("silavandano")) {
                player.GetComponent<Player_Move>().silavan = true;
            } else {
                player.GetComponent<Player_Move>().silavan = false;
            }
        }
    }

    void Update() {
        if (collisionSlime) {
            // Debug.Log("Manteniendo ralentización");
            GlobalVariables.slime_collision = true;
        } else {
            // Debug.Log("Velocidad normal");
            GlobalVariables.slime_collision = false;
            player.GetComponent<Player_Move>().silavan = false;
            GlobalVariables.playerSpeed = GlobalVariables.defaultPlayerSpeed;
            GlobalVariables.jumpHeight = GlobalVariables.defaultJumpHeight;
        }
        collisionSlime = false;
    }
}
