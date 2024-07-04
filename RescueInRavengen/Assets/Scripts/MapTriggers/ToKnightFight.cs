using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToKnightFight : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("KnightFight")) {
            SceneManager.LoadScene("Scenes/BattleScenes/BattleKnight");
        }
    }
}
