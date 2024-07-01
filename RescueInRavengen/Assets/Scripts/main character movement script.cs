using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincharactermovementscript : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Vertical") * Time.deltaTime, 1 * Time.deltaTime);
            for (int i = 1; i < 11; i++)
            {
                transform.Translate(0, 0, Time.deltaTime);
            }
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Vertical") * Time.deltaTime, -11 * Time.deltaTime);
        }
    }
}
