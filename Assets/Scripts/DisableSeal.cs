using UnityEngine;

public class DisableSeal : MonoBehaviour
{
    public GameObject seal;
    public GameObject waterFae;
    public GameObject fireFae;
    public GameObject forestFae;
    public GameObject earthFae;
    public GameObject dialogue;
    public GameObject sealTextureOne;
    public GameObject sealTextureTwo;
    public GameObject sealTextureThree;
    public GameObject sealTextureFour;
    

    void Update()
    {

        int activeCount = 0;

        if (waterFae != null && waterFae.activeSelf)
        {
            activeCount++;

            sealTextureOne.SetActive(false);
        }

        if (fireFae != null && fireFae.activeSelf)
        {
            activeCount++;

            sealTextureTwo.SetActive(false);
        }

        if (forestFae != null && forestFae.activeSelf)
        {
            activeCount++;

            sealTextureThree.SetActive(false);
        }

        if (earthFae != null && earthFae.activeSelf)
        {
            activeCount++;

            sealTextureFour.SetActive(false);
        }

        if (activeCount >= 4)
        {
            if (seal.activeSelf)
            {
                seal.SetActive(false);
            }

            if (!dialogue.activeSelf)
            {
                dialogue.SetActive(true);
            }
        }
    }
}
