using UnityEngine;
//This script is to Destroy a Game Object using the Spacebar

public class PushSpaceToDestroy : MonoBehaviour
{

    public GameObject gameObjectToDestroy;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);

            //Destroy(this);//This deestroys the script attached tp the Game Object

            //Destroy(this.gameObject);//This destroys the Game Object that the script is attached to

            Destroy(gameObjectToDestroy);//This destroys the Game Object that we have referenced in the Inspector
        } 
    }
}
