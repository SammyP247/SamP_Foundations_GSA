using UnityEngine;

public class DisableSeal : MonoBehaviour
{
    public GameObject seal;
    public GameObject waterFae;
    public GameObject fireFae;
    public GameObject earthFae;
    public GameObject forestFae;

    void Update()
    {
        if (waterFae != null)
        {
            seal.SetActive(false);
        }
    }
}
