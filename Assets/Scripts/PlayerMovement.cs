using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed; //changes player speed
    public float gravity = -9.81f; //Earth's gravitational force being used for the game's gravity force.
    public float jumpHeight; //how high the player will jump.

    public Transform groundCheck; //reference for ground check object.
    public float groundDistance = 0.4f; //radius of sphere being used to check if player is on the ground.
    public LayerMask groundMask; //controls what objects ground distance sphere should check for.

    Vector3 velocity; //stores player's current velocity.
    bool isGrounded; //stores if the player is grounded or not. This is required so player cannot jump infinitely as well as assuring the velocity doesn't constantly increase indefinitely.
    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Creates a sphere based on the ground check object's position using groundCheck.position, radius using groundDistance and layer mask using groundMask. 

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //-2 used instead of 0 so that in the case the isGrounded code registers before the player is completely on the ground, the player will be dragged down.
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //Allows player to move based on the direction the player is facing using WASD keys.

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime; //increases the up and down (y axis) velocity by the gravity (9.81) established.

        controller.Move(velocity * Time.deltaTime); //Moves the player based on calculated velocity.
    }
}
