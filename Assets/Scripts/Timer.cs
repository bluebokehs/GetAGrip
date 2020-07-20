using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

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

        minutes = (int)(gameTimer / 60f);
        seconds = (int)(gameTimer % 60f);
        timeText.text = minutes.ToString("0") + ":" + seconds.ToString("00");
    }
}
