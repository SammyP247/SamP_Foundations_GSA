using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   //This script will load the next scene by name, which can be edited in the inspector within Unity.

   public void LoadSceneByName(string sceneName)
   {
    SceneManager.LoadScene(sceneName);
   }
}
