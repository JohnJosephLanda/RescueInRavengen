using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToKingDialogue : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("KingDialogue1")) {
            SceneManager.LoadScene("Scenes/Dialogue/KingDialogue");
        }
    }
}
