using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneForEnd : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        if (BasicTalkSystemForB.index == 35) { 
            StartCoroutine(waitTime());
            SceneManager.LoadScene(sceneName);
        
        }

    }

    IEnumerator waitTime()
    {
        yield return new WaitForSecondsRealtime(5);

    }
}
