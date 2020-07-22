using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LowestTime : MonoBehaviour
{
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = ReformatTime(PlayerPrefs.GetFloat("Time"));
        highScore2.text = ReformatTime(PlayerPrefs.GetFloat("Time"));
        highScore3.text = ReformatTime(PlayerPrefs.GetFloat("Time"));
        highScore4.text = ReformatTime(PlayerPrefs.GetFloat("Time"));
    }

    string ReformatTime (float time)
    {
        int intTime = (int) time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string text = String.Format ("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
        return text;
     }
}
