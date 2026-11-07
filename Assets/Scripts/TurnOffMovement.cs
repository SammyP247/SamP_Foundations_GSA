using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMovement : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject firstPersonPlayer;
    public GameObject userInterface;
    
    void OnEnable()
    {
        if (userInterface != null)
        {
            mainCamera.GetComponent<MouseLook>().enabled = false;

            firstPersonPlayer.GetComponent<PlayerMovement>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
        }
    }

    void OnDisable()
    {
        if (userInterface == null)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
    