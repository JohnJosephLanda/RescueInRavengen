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
    public Rigidbody2D playerRB;
    public Rigidbody2D enemyRB;

    void Start() {
        enemyMoved = false;
        playerMoved = false;
        playerRB = player.GetComponent<Rigidbody2D>();
        enemyRB = enemy.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        StartCoroutine("playerBattle");
        StartCoroutine("enemyBattle");
        if (playerMoved) {
            playerRB.velocity = new Vector2(20f,0);
            playerMoved = false;
            hitSound.Play();
        }
        if (player.transform.position.x > -2) {
            playerRB.velocity = new Vector2(-5f,0);
        }
        if (player.transform.position.x < -7) {
            playerRB.velocity = new Vector2(0,0);
        }
        if (enemyMoved) {
            enemyRB.velocity = new Vector2(-20f,0);
            enemyMoved = false;
            hitSound.Play();
        }
        if (enemyRB.transform.position.x < 2) {
            enemyRB.velocity = new Vector2(5f,0);
        }
        if (enemyRB.transform.position.x > 7) {
            enemyRB.velocity = new Vector2(0,0);
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
