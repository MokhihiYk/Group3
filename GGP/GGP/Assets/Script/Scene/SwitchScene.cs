using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

public class SwitchScene : MonoBehaviour
{
    public GameObject eventObj;
    public Button mainButton;
    public Button configButton;

    [Header("Story")]
    public Button A_Button;
    public Button B_Button;


    public Animator animator;


    void Start() {
        GameObject.DontDestroyOnLoad(this.gameObject);
        GameObject.DontDestroyOnLoad(this.eventObj);

        mainButton.onClick.AddListener(LoadSceneA);
        configButton.onClick.AddListener(LoadSceneB);


    }

    private void LoadSceneA() {
        StartCoroutine(LoadScene(1));
    }
    private void LoadSceneB()
    {
        StartCoroutine(LoadScene(2));
    }


    IEnumerator LoadScene(int index) {
        animator.SetBool("FadeIn", true);
        animator.SetBool("FadeOut", false);

        yield return new WaitForSeconds(1);

        SceneManager.LoadSceneAsync(index);

        AsyncOperation async = SceneManager.LoadSceneAsync(index);
        async.completed += OnLoadedScene;

    }

    private void OnLoadedScene(AsyncOperation obj)
    {
        animator.SetBool("FadeIn", false);
        animator.SetBool("FadeOut", true);
    }
    
}


