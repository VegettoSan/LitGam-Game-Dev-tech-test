using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void ChangeScene(string Scene)
    {
        SceneManager.LoadSceneAsync(Scene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
