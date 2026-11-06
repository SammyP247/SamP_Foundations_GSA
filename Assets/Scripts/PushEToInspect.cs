using UnityEngine;

public class PushEToInspect : MonoBehaviour
{
    public GameObject interaction;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (interaction != null)
            {
                interaction.SetActive(true);
            }
        }
    }
}
