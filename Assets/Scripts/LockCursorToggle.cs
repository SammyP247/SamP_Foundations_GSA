using UnityEngine;

public class LockCursorToggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            bool isLocked = Cursor.lockState == CursorLockMode.Locked;
            Cursor.visible = isLocked;
            Cursor.lockState = isLocked ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }
}
