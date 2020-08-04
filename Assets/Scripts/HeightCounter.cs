using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightCounter : MonoBehaviour
{

    public Transform target;
    public Text height;
    public Text finalHeight;
    public GameObject highScoreBanner;

    int initHeightValue = 0;
    int currentPos = 0;
    int oldPos = -1;

    // Start is called before the first frame update
    void Start()
    {
        height = GetComponent<Text>();
        initHeightValue = (int)target.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = (int)target.position.y - initHeightValue;

        // only updates the height if the player is going up
        if (currentPos > oldPos)
        {
            height.text = currentPos.ToString("0");
            finalHeight.text = currentPos.ToString("0");

            if (currentPos > GameControl.control.score)
            {
                GameControl.control.score = currentPos;
                highScoreBanner.SetActive(true);
                GameControl.control.Save();
            }
        }
        
        oldPos = currentPos;
    }
}
