﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5f;
    }

    // Update is called once per frame
    private void Update()
    {
/*        dirX = Input.GetAxisraw("Horizontal")* moveSpeed;

        if(Mathf.Abs(dirX)>0 && rb.velocity.y == 0)
            anim.SetBool("isRunning", true);
        else
            anim.SetBool("isRunning",false);
*/
        
    }

    /*private void FixedUpdate(){
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate(){
        if(dirX>0)
            facingRight = true;
        else if (dirX<0)
            facingRight = false;

        if( ( (facingRight) && (localScale.x<0) ) || (!facingRight) && (localScale.x > 0))
            localScale.x *= -1;
            transform.localScale = localScale;
    }
*/
}
