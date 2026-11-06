using UnityEngine;

public class TurnOffMovement : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject firstPersonPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void onEnable()
    {
        mainCamera.GetComponent<MouseLook>().enabled = false;

        firstPersonPlayer.GetComponent<PlayerMovement>().enabled = false;
    }
}
