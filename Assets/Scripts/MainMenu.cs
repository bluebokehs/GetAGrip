using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource source;

    public void PlayEndlessGame()
    {
        StartCoroutine(FinishSound());
        SceneManager.LoadScene("EndlessMode");
        Time.timeScale = 1f;
    }
    public void PlaySpeedGame()
    {
        StartCoroutine(FinishSound());
        SceneManager.LoadScene("SpeedMode");
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
}
