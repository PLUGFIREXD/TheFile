using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public void playGame()
        {
            SceneManager.LoadSceneAsync(1);
        }
    public void Exit()
    {
        Application.Quit();
    }
}
