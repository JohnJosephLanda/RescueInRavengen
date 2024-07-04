using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScriptForBoth : MonoBehaviour
{
    //create two battlescripts; one for character, another for enemy
    public int characterhealth = 6;
    public int characterattack = 2;
    public int enemyhealth = 10;
    public int enemyattack = 1;
    [SerializeField] int enemyAttackFrames = 2000;
    int enemyFramesSinceAttack = 0;
    public GameObject player;
    public GameObject enemy;


    //according to unity discussions, adding public static in front of something makes in global

    void Start()
    {
        StartCoroutine("playerBattle");
        StartCoroutine("enemyBattle");
    }
    void Update() {
        
    }
    IEnumerator playerBattle() {
        if (Input.GetKey(KeyCode.Space)) {
            player.transform.Translate(2.5f,0,0);
            enemyhealth = enemyhealth - characterattack;
            yield return new WaitForSeconds(.1f);
            player.transform.Translate(-2.5f,0,0);
        }

        if (enemyhealth <= 0)
        {
            enemyhealth = 0;
            SceneManager.LoadScene("BattleWin");
        }
        StartCoroutine("playerBattle");
    }
    
    IEnumerator enemyBattle() {
        if (enemyAttackFrames <= enemyFramesSinceAttack) {
            enemy.transform.Translate(-2.5f,0,0);
            characterhealth = characterhealth - enemyattack;
            yield return new WaitForSeconds(.1f);
            enemy.transform.Translate(2.5f,0,0);
        }

        if (characterhealth <= 0)
        {
            characterhealth = 0;
            SceneManager.LoadScene("BattleLoss");
        }
        enemyFramesSinceAttack++;
        StartCoroutine("enemyBattle");
    }
}
