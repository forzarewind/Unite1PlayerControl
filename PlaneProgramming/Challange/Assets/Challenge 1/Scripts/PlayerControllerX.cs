using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed;
    public float verticalInput;
    public InputAction MoveAction;
    public Vector3 MoveInput; 
        // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        MoveInput = MoveAction.ReadValue<Vector3>();
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * MoveInput.y);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * MoveInput.x);
            }
}
