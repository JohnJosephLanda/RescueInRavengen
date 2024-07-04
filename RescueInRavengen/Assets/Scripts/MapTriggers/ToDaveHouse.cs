using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDaveHouse : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("DaveHouse")) {
            SceneManager.LoadScene("Scenes/ReusedScenes/DaveHouseFromMap");
        }
    }
}
