using UnityEngine;

public class DisableSeal : MonoBehaviour
{
    public GameObject seal;
    public GameObject waterFae;
    public GameObject fireFae;
    public GameObject forestFae;
    public GameObject earthFae;
    

    void Update()
    {

        int activeCount = 0;

        if (waterFae != null && waterFae.activeSelf)
        {
            activeCount++;
        }

        if (fireFae != null && fireFae.activeSelf)
        {
            activeCount++;
        }

        if (forestFae != null && forestFae.activeSelf)
        {
            activeCount++;
        }

        if (earthFae != null && earthFae.activeSelf)
        {
            activeCount++;
        }

        if (activeCount >= 4)
        {
            if (seal.activeSelf)
            {
                seal.SetActive(false);
            }
        }
    }
}
