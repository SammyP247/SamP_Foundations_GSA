using UnityEngine;

public class AnimationEventWithFaeScript : MonoBehaviour
{
    public GameObject fae;

    public void SpawnFaeEvent()
    {
        fae.SetActive(true);
    }
}
