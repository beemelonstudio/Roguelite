using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    [SerializeField] public Rouguelite controls;
    private Animator animator;

    private void Awake()
    {
        this.animator = GetComponent<Animator>();

        controls.Player.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Move(Vector2 direction)
    {
        transform.position += new Vector3(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime, 0f);
    }
}
