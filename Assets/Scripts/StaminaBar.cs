using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;

    public float maxVal = 100;

    public float minVal = 0;

    public float currentVal = 0;

    public float speed = 5;

    void Update()
	{
        currentVal += Time.deltaTime * speed;

        if (currentVal >= maxVal)
		{
            speed *= -1;
            currentVal = maxVal;
		}
        else if (currentVal <= minVal)
		{
            speed *= -1;
            currentVal = minVal;
        }

        slider.value = currentVal;
	}
}
