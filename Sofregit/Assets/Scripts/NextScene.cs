 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class NextScene : MonoBehaviour
{
    public void ManageScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Comming from" + scene.name);

        if (scene.name == "MenuScene")
            SceneManager.LoadScene("Level1");

        else if (scene.name == "Level1")
        {
            Debug.Log("Hacia la escena 2");
            SceneManager.LoadScene("Level2");
        }
            

        else if (scene.name == "Level2")
            SceneManager.LoadScene("Level3");

        else if (scene.name == "Level3")
            SceneManager.LoadScene("Level4");

        else if (scene.name == "Level4")
            SceneManager.LoadScene("Level5");

        else if (scene.name == "Level5")
            SceneManager.LoadScene("MenuScene");

    }
}