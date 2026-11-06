using UnityEngine;

public class TurnOffMovement : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject firstPersonPlayer;
    
    void onEnable()
    {
        mainCamera.GetComponent<MouseLook>().enabled = false;

        firstPersonPlayer.GetComponent<PlayerMovement>().enabled = false;
    }
}
