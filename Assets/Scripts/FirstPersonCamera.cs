using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    // CThe camera attached to the player
    public Camera playerCamera;

    // Container variables for the mouse delata values each frame
    public float deltaX;
    public float deltaY;

    // Container variables for the player's rotation around the X and Y azis
    public float xRot; // rotation around the x-axis in degrees
    public float yRot; // rotation around the y-axis in degrees

    public float mouseSensitivity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main; // set player camera
        Cursor.visible = false; // hide the cursor
    }

    // Update is called once per frame
    void Update()
    {
        yRot += deltaX;
        xRot -= deltaY;

        // keep the player's x rotation clam;s engative [-90,90] degrees
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        // rotate the camera around the x-axis
        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }


    // OnCamera event handler
    public void OnCameraLook(InputValue value)
    {
        // write code to handle the event.
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x * mouseSensitivity * Time.deltaTime;
        deltaY = inputVector.y * mouseSensitivity * Time.deltaTime;

    }
}
