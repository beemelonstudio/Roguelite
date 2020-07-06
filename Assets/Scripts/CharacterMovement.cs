using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    private Rouguelite controls;

    private new Rigidbody2D rigidbody2D;
    private Animator animator;

    private void Awake()
    {
        this.animator = GetComponent<Animator>();
        this.rigidbody2D = GetComponent<Rigidbody2D>();

        controls = new Rouguelite();
    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = controls.Player.Move.ReadValue<Vector2>();
        Move(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        if (direction.x != 0 && direction.y != 0)
        {
            direction /= 2f;
        }

        this.rigidbody2D.velocity = direction.normalized * speed;
    }
    
    void OnEnable() 
    {
        controls.Player.Enable();
    }
    void OnDisable() 
    {
        controls.Player.Disable();
    }
}
