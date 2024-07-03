using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScriptForBoth : MonoBehaviour
{
    //create two battlescripts; one for character, another for enemy
    public int characterhealth = 1000;
    public int characterattack = 100;
    public int enemyhealth = 2000;
    public int enemyattack = 25;
    [SerializeField] int enemyAttackFrames = 100;
    int enemyFramesSinceAttack = 0;
    public GameObject player;
    public GameObject enemy;


    //according to unity discussions, adding public static in front of something makes in global

    void Start()
    {
        
    }
    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            for (int i = 0; i < 32; i++)
            {
                player.transform.Translate(.05f,0,0);
            }
            //plus or minus 8 for x pos for character and enemy
            enemyhealth = enemyhealth - characterattack;
            for (int i = 0; i < 32; i++)
            {
                player.transform.Translate(-.05f,0,0);
            }
        }
        if (enemyAttackFrames <= enemyFramesSinceAttack) {
            for (int i = 0; i < 32; i++)
            {
                enemy.transform.Translate(-.05f,0,0);
            }
            characterhealth = characterhealth - enemyattack;
            for (int i = 0; i < 32; i++)
            {
                enemy.transform.Translate(.05f,0,0);
            }
        }

        if (enemyhealth <= 0)
        {
            enemyhealth = 0;
            SceneManager.LoadScene("BattleWin");
        }
        if (characterhealth <= 0)
        {
            characterhealth = 0;
            SceneManager.LoadScene("BattleLoss");
        }
        enemyFramesSinceAttack++;
    }
}
