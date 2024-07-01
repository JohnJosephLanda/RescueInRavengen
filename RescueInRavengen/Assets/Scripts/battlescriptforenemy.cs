using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//class name.var name = 10;
//Debug.Log(class name, var names);
//add collider/rigidbody for both enemy and main character

public class battlescriptforenemy : MonoBehaviour
{
    //create two battlescripts; one for character, another for enemy

    //according to unity discussions, adding public static in front of something makes in global

    void Start()
    {
        transform.position = new Vector3(8, 0, 0);
    }
    void Update()
    {
        if (!battlescriptforcharacter.playerturn)
        {
            //not sure if the condition can shorten to (!"condition")
            transform.Translate(-16 * Time.deltaTime, 0, 0);
            battlescriptforcharacter.characterhealth = battlescriptforcharacter.characterhealth - battlescriptforcharacter.enemyattack;
            transform.Translate(16 * Time.deltaTime, 0, 0);
            battlescriptforcharacter.playerturn = true;
        }
    }
}
