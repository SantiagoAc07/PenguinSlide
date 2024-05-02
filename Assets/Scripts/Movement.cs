using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public Rigidbody2D rb;


    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        

        Vector2 movement = new Vector2(horizontal, 0);
        rb.velocity = movement * speed;
    }
    
    
}
