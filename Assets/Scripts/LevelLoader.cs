using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public DragForce dF;

    public float transitionTime = 1f;

    void Start()
    {
        dF = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();
    }

    public void PlayTutorial()
    {
        StartCoroutine(Transition("Tutorial"));
        Time.timeScale = 1f;
    }

    public void PlayEndlessGame()
    {
        StartCoroutine(Transition("EndlessMode"));
        Time.timeScale = 1f;
    }
    
    public void PlaySpeedGame()
    {
        StartCoroutine(Transition("SpeedMode"));
        Time.timeScale = 1f;
    }

    public void PlayMenu()
    {
        StartCoroutine(Transition("Menu"));
        Time.timeScale = 1f;
    }

    IEnumerator Transition(string levelName)
    {
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            dF.touchUI = true;
        }
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelName);
    }
}
