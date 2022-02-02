using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatorScript : MonoBehaviour
{
    // variables
    public float rotationSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    void R(InputAction.CallbackContext context)
    {
        this.GetComponent<Transform>().Rotate(0f,rotationSpeed,0f);
    }

    void T(InputAction.CallbackContext context)
    {
        this.GetComponent<Transform>().Rotate(0f,-rotationSpeed,0f);
    }
}
