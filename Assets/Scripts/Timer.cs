using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public GameObject winMenu;
    public Text timeText;

    public float seconds, minutes;
    float gameTimer;
    public bool timerPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timerPaused)
        {
            gameTimer += Time.deltaTime;
        }

        timeText.text = FormatTime(gameTimer);
    }

    string FormatTime (float time)
    {
        int intTime = (int)time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string text = String.Format ("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);

        if (time < PlayerPrefs.GetFloat("Time") && winMenu.activeInHierarchy)
        {
            PlayerPrefs.SetFloat("Time", gameTimer);
        }
        return text;
     }
}
