using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapMovement : MonoBehaviour
{
    public float sprint = 1f;
    [SerializeField] float moveSpeed = 500f;
    Animator animator;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("HasKnife", false);
        transform.position = new Vector3(-7, -3, 0);
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
        direction = new Vector2(Input.GetAxis("Horizontal")*sprint*Time.deltaTime*moveSpeed, Input.GetAxis("Vertical")*sprint*Time.deltaTime*moveSpeed);

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", -direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
    }
}
