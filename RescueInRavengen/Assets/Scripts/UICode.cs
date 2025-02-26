using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICode : MonoBehaviour {
    Animator animator;
    public GameObject player;
    public static int characterhealth = 6;
    public int prevcharacterhealth;
    public Image h1;
    public Image h2;
    public Image h3;
    public Sprite halfheart;
    public Sprite noheart;

    void Start () {
        if (characterhealth == 6) {return;}
        else if (characterhealth == 5) {
            h1.GetComponent<Image>().sprite = halfheart;
        }
        else if (characterhealth == 4) {
            h1.GetComponent<Image>().sprite = noheart;
        }
        else if (characterhealth == 3) {
            h1.GetComponent<Image>().sprite = noheart;
            h2.GetComponent<Image>().sprite = halfheart;
        }
        else if (characterhealth == 2) {
            h1.GetComponent<Image>().sprite = noheart;
            h2.GetComponent<Image>().sprite = noheart;
        }
        else if (characterhealth == 1) {
            h1.GetComponent<Image>().sprite = noheart;
            h2.GetComponent<Image>().sprite = noheart;
            h3.GetComponent<Image>().sprite = halfheart;
        }
        prevcharacterhealth = characterhealth;
    }

    void Update() {
        if (BattleScriptForBoth.characterhealth != characterhealth) {
            characterhealth = BattleScriptForBoth.characterhealth;
            if (characterhealth == 5) {
                h1.GetComponent<Image>().sprite = halfheart;
            }
            else if (characterhealth == 4) {
                h1.GetComponent<Image>().sprite = noheart;
            }
            else if (characterhealth == 3) {
                h1.GetComponent<Image>().sprite = noheart;
                h2.GetComponent<Image>().sprite = halfheart;
            }
            else if (characterhealth == 2) {
                h1.GetComponent<Image>().sprite = noheart;
                h2.GetComponent<Image>().sprite = noheart;
            }
            else if (characterhealth == 1) {
                h1.GetComponent<Image>().sprite = noheart;
                h2.GetComponent<Image>().sprite = noheart;
                h3.GetComponent<Image>().sprite = halfheart;
            }
        }
    }
}