using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCD : MonoBehaviour
{
    public float timeCount;
    public float timeCD;
    public Image image;
    public Text text;
    public Button btn;
    public bool isCooling;
    public float timeHaveSkill =3;
    public float runSpeed;
    public float normalSpeed;

                          // Use this for initialization
    void Start()
    {

    }
    public void BtnEvent()
    {
        if (!isCooling)
        {
            image.fillAmount = 1;
            image.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            text.text = timeCD.ToString("f1");
            isCooling = true;
            timeCount = timeCD;
           
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (isCooling)
        {
            timeCount -= Time.deltaTime;
            image.fillAmount = timeCount / timeCD;
            text.text = timeCount.ToString("f1");
            
            if(timeCount >=timeHaveSkill)
                Player.moveSpeed = runSpeed;
            if (timeCount < timeHaveSkill)
                Player.moveSpeed = normalSpeed;
            if (timeCount <= 0)
            {
                isCooling = false;
                image.gameObject.SetActive(false);
                text.text = timeCount.ToString("Speed Up!!");
                text.gameObject.SetActive(true);
            }
        }
    }
}