using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public float restartDelay = 1f;

    public GameObject winScreen;

    public GameObject timerObject;
    public GameObject timerObjectFinal;

    Timer timer;
    Text timerText;
    Text timerTextFinal;

    // Start is called before the first frame update
    void Start ()
    {
        timer = timerObject.GetComponent<Timer>();
        timerText = timerObject.GetComponent<Text>();
        timerTextFinal = timerObjectFinal.GetComponent<Text>();
    }

    public void WinGame ()
    {
        if (SceneManager.GetActiveScene().name != "EndlessMode")
        {
            timer.timerPaused = true;
        }
        Invoke("WinScreen", restartDelay);
    }

    void WinScreen ()
    {
        if (SceneManager.GetActiveScene().name != "EndlessMode")
        {
            timerTextFinal.text = timerText.text;
        }
        winScreen.SetActive(true);
    }

    public void Restart ()
	{
        if (SceneManager.GetActiveScene().name != "EndlessMode")
        {
            timer.timerPaused = false;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
