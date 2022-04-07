using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicTalkSystem : MonoBehaviour
{
    [Header("UI")]
    public Text textLabel;
    public Image faceImage;

    [Header("Text")]
    public TextAsset textFile;
    public static int index;
    public float textSpeed = 0.1f;

    [Header("Icon")]
    public Sprite face01, face02;

    [Header("Button")]
    public GameObject Button0;

    bool textFinished;

    List<string> textList = new List<string>();

    void Awake() {
        GetTextFromFile(textFile);
        index = 0;
    }
    private void OnEnable() {
        //textLabel.text = textList[index];
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse0) && index == textList.Count) {
            gameObject.SetActive(false);
            index = 0;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)&& textFinished) {
            //textLabel.text = textList[index];
            //index++;
            StartCoroutine(SetTextUI());
        }

        if (index == 3||index ==4) {               //For Show Button follow by IndexLine
            Button0.SetActive(true);
        }else
            Button0.SetActive(false);
    }

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineData = file.text.Split('\n');

        foreach (var line in lineData)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI() {

        textFinished = false;
        textLabel.text = "";

        switch (textList[index].Trim()) 
        {
            case "A":           //A can be change
                faceImage.sprite = face01;
                index++;       //use for skip the Character Name
                break;  
            case "B":          //B can be change
                faceImage.sprite = face02;
                index++;    
                break;
        }

        for (int i = 0; i < textList[index].Length; i++) {
            textLabel.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true;
        index++;
    }
}
