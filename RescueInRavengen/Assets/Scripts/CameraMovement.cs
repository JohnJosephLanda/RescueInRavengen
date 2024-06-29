using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float steerAmount;
    [SerializeField] float moveSpeed = 15f;
    private float moveAmount;
    private float sprint;
    // Start is called before the first frame update
    void Start()
    {
        sprint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            sprint++;
            if (sprint > 2) {
                sprint = 1;
            }
        }
        steerAmount = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime*sprint;
        moveAmount = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime*sprint;
        transform.Translate(steerAmount,moveAmount,0);
    }
}
