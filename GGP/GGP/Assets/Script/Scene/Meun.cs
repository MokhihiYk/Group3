using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meun : MonoBehaviour
{
    public GameObject pauseMeun;


    public void PauseGame() {
        pauseMeun.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pauseMeun.SetActive(false);
        Time.timeScale = 1f;
    }

    public void BackScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
}
