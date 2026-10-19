using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed; //changes player speed
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //Allows player to move based on the direction the player is facing using WASD keys.

        controller.Move(move * speed * Time.deltaTime);
    }
}
