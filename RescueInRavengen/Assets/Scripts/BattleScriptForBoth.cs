using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScriptForBoth : MonoBehaviour
{
    //create two battlescripts; one for character, another for enemy
    public static int characterhealth = UICode.characterhealth;
    public int characterattack = 2;
    public int enemyhealth = 10;
    public int enemyattack = 1;
    [SerializeField] int enemyAttackFrames = 100;
    public int enemyFramesSinceAttack = 0;
    public GameObject player;
    public GameObject enemy;
    private bool playerMoved;
    private bool enemyMoved;
    public AudioSource hitSound;

    void Start() {
        enemyMoved = false;
        playerMoved = false;
    }

    void Update()
    {
        StartCoroutine("playerBattle");
        StartCoroutine("enemyBattle");
        if (playerMoved) {
            player.transform.Translate(2.5f,0,0);
            player.transform.Translate(-2.5f,0,0);
            playerMoved = false;
            hitSound.Play();
        }
        if (enemyMoved) {
            enemy.transform.Translate(-2.5f,0,0);
            enemy.transform.Translate(2.5f,0,0);
            enemyMoved = false;
            hitSound.Play();
        }
    }
    
    IEnumerator playerBattle() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            enemyhealth = enemyhealth - characterattack;
            playerMoved = true;
            yield return new WaitForSeconds(.1f);
        }

        if (enemyhealth <= 0)
        {
            enemyhealth = 0;
            SceneManager.LoadScene("BattleWin");
        }
        StopCoroutine("playerBattle");
    }
    
    IEnumerator enemyBattle() {
        if (enemyAttackFrames <= enemyFramesSinceAttack) {
            enemyFramesSinceAttack = 0;
            characterhealth = characterhealth - enemyattack;
            enemyMoved = true;
            yield return new WaitForSeconds(.1f);
        }

        if (characterhealth <= 0)
        {
            characterhealth = 0;
            SceneManager.LoadScene("BattleLoss");
        }
        enemyFramesSinceAttack++;
        StopCoroutine("enemyBattle");
    }
}
