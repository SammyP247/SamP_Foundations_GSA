using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator animator;

    public Transform playerCheck;
    public float playerDistance;
    public LayerMask playerMask;

    bool playerNear;
    // This script is to click to trigger an animation on the object the script is attached to.
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        playerNear = Physics.CheckSphere(playerCheck.position, playerDistance, playerMask);

        if (playerNear)
        {
            animator.SetBool("IsClicked", true);
        }
    }
}
