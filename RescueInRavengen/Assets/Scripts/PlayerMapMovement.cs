using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    Animator animator;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("HasKnife", false);
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed);
        rb.velocity = new Vector2(direction.x, direction.y);

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", -direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
    }
}
