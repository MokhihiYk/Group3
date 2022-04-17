using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text MyScoreText;
    public static float ScoreNum;
    public GameObject choose1;
    public GameObject choose2;
    public GameObject choose3; 
    public GameObject choose4;

    public GameObject End;

    public GameObject Spawner;

    void Start() {
        ScoreNum = 0;
        
        MyScoreText.text = "Score: " + ScoreNum;
    }

    void Update()
    {
        MyScoreText.text = "Score: " + ScoreNum;

        if (ScoreNum == 100) {
            Time.timeScale = 0f;
            choose1.SetActive(true);
        }
        if (ScoreNum == 250)
        {
            Spawner.SetActive(true);
        }
        if (ScoreNum == 500)
        {
            Time.timeScale = 0f;
            choose2.SetActive(true);
        }
        if (ScoreNum == 700)
        {
            Time.timeScale = 0f;
            choose3.SetActive(true);
        }

        if (ScoreNum == 950)
        {
            Time.timeScale = 0f;
            choose4.SetActive(true);
        }
        if (ScoreNum >= 1000) { 
            Time.timeScale = 0f;
            End.SetActive(true);
        }

    }
}
