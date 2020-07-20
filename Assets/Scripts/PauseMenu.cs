using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public DragForce dF;

    void Start()
    {
        dF = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();
    }

    public void PauseHandler ()
    {
        if (GameIsPaused)
		{
            Resume();
		}
        else
		{
            Pause();
		}
    }

    public void Resume ()
	{
        dF.touchUI = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
	{
        dF.touchUI = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
	}
}
