using UnityEngine;

public class CLickToInspect : MonoBehaviour
{
    public GameObject interaction;

    public Transform playerCheck;
    public float playerDistance;
    public LayerMask playerMask;

    bool playerNear;

    void OnMouseDown()
    {

        playerNear = Physics.CheckSphere(playerCheck.position, playerDistance, playerMask);

            if (playerNear && interaction != null)
            {
                interaction.SetActive(true);
            }
    }
}
