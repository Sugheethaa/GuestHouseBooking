using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName1;
    public string sceneName2;
    public string sceneName3;

    public void LoadScene1()
    {
        SceneManager.LoadScene(sceneName1);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(sceneName2);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(sceneName3);
    }
}