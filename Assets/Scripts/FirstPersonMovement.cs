using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    // Player's movement paramss
    public Vector3 direction;
    public float speed;

    public Rigidbody rb; // Player's rigid body

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.Translate(direction * speed * Time.deltaTime);
        Vector3 localDirection = transform.TransformDirection(direction);
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    // On player move event handler
    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        // move in the XZ plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }

    public void OnQuit(InputValue value)
    {
        print("Quiting");
        Application.Quit();
    }
}
