using UnityEngine;

public class CLickToInspect : MonoBehaviour
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
