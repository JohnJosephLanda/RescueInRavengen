using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaknightscript : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") *speed, 0);
    }
}