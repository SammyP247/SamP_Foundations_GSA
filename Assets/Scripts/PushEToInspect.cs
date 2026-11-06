using UnityEngine;

public class PushEToInspect : MonoBehaviour
{
    public GameObject interaction;

    void OnMouseDown()
    {
            if (interaction != null)
            {
                interaction.SetActive(true);
            }
    }
}
