using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public AudioSource source;
    public Animator transition;

    public float transitionTime = 1f;

    public void PlayEndlessGame()
    {
        StartCoroutine(FinishSound());
        StartCoroutine(Transition("EndlessMode"));
        Time.timeScale = 1f;
    }
    public void PlaySpeedGame()
    {
        StartCoroutine(FinishSound());
        StartCoroutine(Transition("SpeedMode"));
        Time.timeScale = 1f;
    }

    public void PlayMenu()
    {
        StartCoroutine(FinishSound());
        StartCoroutine(Transition("Menu"));
        Time.timeScale = 1f;
    }

    public void PlaySound()
    {
        StartCoroutine(FinishSound());
    }

    IEnumerator FinishSound()
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
    }

    IEnumerator Transition(string levelName)
    {
        transition.SetTrigger("Start");
        Debug.Log("before");
        yield return new WaitForSeconds(transitionTime);
        Debug.Log("after");
        SceneManager.LoadScene(levelName);
    }
}
