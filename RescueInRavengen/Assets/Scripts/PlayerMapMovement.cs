using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapMovement : MonoBehaviour
{
    public float sprint = 1f;
    [SerializeField] float moveSpeed = 500f;
    Rigidbody2D rb;
    Animator animator;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
        direction = new Vector2(Input.GetAxis("Horizontal")*sprint*Time.deltaTime*moveSpeed,Input.GetAxis("Vertical")*sprint*Time.deltaTime*moveSpeed);
        rb.velocity = new Vector2(direction.x, direction.y);

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", -direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
    }
}
