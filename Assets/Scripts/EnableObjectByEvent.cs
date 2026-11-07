using UnityEngine;

public class EnableObjectByEvent : MonoBehaviour
{
     public GameObject activatedObject;

    public void SpawnObjectEvent()
    {
        activatedObject.SetActive(true);
    }
}
