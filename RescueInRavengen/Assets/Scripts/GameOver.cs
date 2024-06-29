using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMusic : MonoBehaviour
{
    // Update is called once per frame
    public void button1()
    {
        SceneManager.LoadScene("DaveHouse");
    }
    public void button2()
    {
        SceneManager.LoadScene("MainPage");
    }
}
