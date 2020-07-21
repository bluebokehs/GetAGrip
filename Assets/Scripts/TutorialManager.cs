using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;

    public Hold jug;
    public Hold jug1;
    public Hold pinch;
    public Hold sloper;

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
            if(jug.holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 1)
        {
            if(jug1.holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            if(pinch.holdAttached)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if(sloper.holdAttached)
            {
                popUpIndex++;
            }
        }
    }
}
