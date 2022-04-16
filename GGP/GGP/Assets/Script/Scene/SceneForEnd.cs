using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneForEnd : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
         
            StartCoroutine(waitTime());
            SceneManager.LoadScene(sceneName);
        
        

    }

    IEnumerator waitTime()
    {
        yield return new WaitForSecondsRealtime(3);

    }
}
