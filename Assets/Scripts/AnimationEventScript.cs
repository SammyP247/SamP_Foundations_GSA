using UnityEngine;

public class AnimationEventScript : MonoBehaviour
{
    public GameObject searching;
    public GameObject foundOrNotFound;
    public GameObject button;

    public void DespawnObjectEvent()
    {
        searching.SetActive(false);
    }

    public void SpawnObjectEvent()
    {
        foundOrNotFound.SetActive(true);
        button.SetActive(true);
    }
}
