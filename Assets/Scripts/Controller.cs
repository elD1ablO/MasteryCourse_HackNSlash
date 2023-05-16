using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    [SerializeField] private float speed = 3f;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Attack.performed += Attack;
    }

    private void Attack(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack!");
    }

    private void Update()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        Vector3 moveDir = new(inputVector.x, inputVector.y, 0);

        transform.position += speed * Time.deltaTime * moveDir;


    }
}
