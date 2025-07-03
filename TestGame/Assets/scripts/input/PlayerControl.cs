using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    
    private Vector2 movement;
    private Rigidbody2D rb;
    public PlayerInput playerControls;
    private InputAction move;

    private Animator myAnymator;
    private SpriteRenderer mySpriteRenderer;

    private void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    private void Awake()
    {
        playerControls = new PlayerInput();
        rb = GetComponent<Rigidbody2D>();
        myAnymator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMove(InputValue inputValue)
    {
        movement = move.ReadValue<Vector2>();
        if (Input.GetButtonDown("D"))
        {
            myAnymator.SetBool("XRight", true);

        }
        if (Input.GetButtonDown("A"))
        {
            myAnymator.SetBool("XLeft", true);

        }
        if (Input.GetButtonDown("W"))
        {
            myAnymator.SetBool("YUp", true);

        }
        if (Input.GetButtonDown("S"))
        {
            myAnymator.SetBool("YDown", true);

        }
    }

}
