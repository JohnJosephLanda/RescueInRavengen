using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToThroneRoom : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("ThroneRoom")) {
            SceneManager.LoadScene("Scenes/Day1/ThroneRoom");
        }
    }
}
