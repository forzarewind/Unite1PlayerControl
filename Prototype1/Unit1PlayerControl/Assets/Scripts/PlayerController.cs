using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //movement tuning(editable in inspectable)
    public float speed = 5.0f;
    public float turnSpeed = 100F;
    //input system action exposed for binding (WASD/arrow keys)
        public InputAction MoveAction;
  //current input value(x = left/right, y = forward/backwards) kept private for internal use 
    private Vector2 moveInput;
      // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //enable the MoveAction so its reads the inputs
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
     //Read the 2D vector from the MoveAction(x: horizontal, y:vertical)
        moveInput = MoveAction.ReadValue<Vector2>();
        //Move forward/back along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        //Rotate around local Y (Yaw)  the x copmponent
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
           
}