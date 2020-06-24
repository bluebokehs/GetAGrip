using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource source;

    public void PlayGame()
    {
        StartCoroutine(FinishSound());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
