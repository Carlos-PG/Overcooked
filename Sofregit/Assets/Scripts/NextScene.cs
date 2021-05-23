 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class NextScene : MonoBehaviour
{
    public void ManageScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MenuScene")
            SceneManager.LoadScene("Level1");
    }
}