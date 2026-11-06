using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity;

    public Transform playerBody; //Allows reference for main camera to rotate entire First Person Player object around.

    float xRotation = 0f;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Assures cursor won't leave the game screen and click outside the Game window.
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; 

        playerBody.Rotate(Vector3.up * mouseX); //side to side camera movement rotating around the Y-axis

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Assures the player cannot over rotate and end up having an inverted view

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Used instead of rotate script used for mouseX to allow clamping
    }
}
