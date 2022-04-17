using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour
{
    public GameObject choose1;

    public void Correct()
    {
        ScoreCount.ScoreNum += 100;
        choose1.SetActive(false);
        Time.timeScale = 1f;
    }
    public void NotCorrect()
    {
        
        ScoreCount.ScoreNum -= 50;
        choose1.SetActive(false);
        Time.timeScale = 1f;

    }

}
