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
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            dF = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();
        }
    }

    public void PlayTutorial()
    {
        StartCoroutine(Transition("Tutorial"));
    }

    public void PlayEndlessGame()
    {
        StartCoroutine(Transition("EndlessMode"));
    }
    
    public void PlayHappyFeet()
    {
        StartCoroutine(Transition("HappyFeet"));
    }

    public void PlayRockyRoad()
    {
        StartCoroutine(Transition("RockyRoad"));
    }    

    public void PlaySingingInTheStrain()
    {
        StartCoroutine(Transition("SingingInTheStrain"));
    }

    public void PlayBackInCrack()
    {
        StartCoroutine(Transition("BackInCrack"));
    }

    public void PlayCaliceInMalice()
    {
        StartCoroutine(Transition("CaliceInMalice"));
    }

    public void PlayLivingOnALayer()
    {
        StartCoroutine(Transition("LivingOnALayer"));
    }
    public void PlayPebbleTrebble()
    {
        StartCoroutine(Transition("PebbleTrebble"));
    }

    public void PlayCruisingForABruising()
    {
        StartCoroutine(Transition("CruisingForABruising"));
    }

    public void PlayMenu()
    {
        StartCoroutine(Transition("Menu"));
    }

    IEnumerator Transition(string levelName)
    {
        if (SceneManager.GetActiveScene().name != "Menu")
        {
            dF.touchUI = true;
        }
        // unpauses
        Time.timeScale = 1f;
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelName);
    }
}
