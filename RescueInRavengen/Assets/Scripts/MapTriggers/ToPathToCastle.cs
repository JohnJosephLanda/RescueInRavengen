using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPathToCastle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Path")) {
            SceneManager.LoadScene("Scenes/ReusedScenes/PathToCastle");
        }
    }
}
