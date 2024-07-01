using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//class name.var name = 10;
//Debug.Log(class name, var names);

//add collider/rigidbody for both enemy and main character

public class battlescriptforcharacter : MonoBehaviour
{
    //create two battlescripts; one for character, another for enemy
    public static int characterhealth = 1000;
    public static int characterattack = 100;
    public static int enemyhealth = 2000;
    public static int enemyattack = 25;
    public static bool characterwin = false;
    public static bool enemywin = false;
    public static bool playerturn = true;
    //according to unity discussions, adding public static in front of something makes in global

    void Start()
    {
        SceneManager.LoadScene("battlescene");
        transform.position = new Vector3(-8, 0, 0);
    }
    void Update()
    {
        if (playerturn)
        {
            transform.Translate(16 * Time.deltaTime, 0, 0);
            //plus or minus 8 for x pos for character and enemy
            enemyhealth = enemyhealth - characterattack;
            transform.Translate(-16 * Time.deltaTime, 0, 0);
            playerturn = false;
        }
        if (enemyhealth <= 0)
        {
            enemyhealth = 0;
            characterwin = true;
            SceneManager.LoadScene("characterwin");
            //maybe just go back to the map and have text showing that the player has won?
        }
        if (characterhealth <= 0)
        {
            characterhealth = 0;
            enemywin = true;
            SceneManager.LoadScene("characterlost");
        }
       
    }
}
