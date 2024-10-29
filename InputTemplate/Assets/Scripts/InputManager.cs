using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private void OnFire()
    {
        Debug.Log("Fire!");
    }

    private void OnJump()
    {
        Debug.Log("Jump!");
    }

    private void OnInteract()
    {
        Debug.Log("Interact!");
    }
    
    private void OnMove(InputValue value  )
    {
        Debug.Log("Moving!: " + value.Get<Vector2>());
    }
}
