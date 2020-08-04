using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;

    public GameObject jug;
    public GameObject jug1;
    public GameObject pinch;
    public GameObject sloper;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if(jug.GetComponent<Hold>().holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 1)
        {
            if(jug1.GetComponent<Hold>().holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            if(pinch.GetComponent<Hold>().holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if(sloper.GetComponent<Hold>().holdAttached)
            {
                popUpIndex++;
            }
        }
    }
}
