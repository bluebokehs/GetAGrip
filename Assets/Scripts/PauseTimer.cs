using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTimer : MonoBehaviour
{
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer.timerPaused = true;
    }
}
