using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTimer : MonoBehaviour
{
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name != "EndlessMode")
        {
            timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        }
        timer.timerPaused = true;
    }
}
