using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    string white = "white";
    string black = "black";

    public void ChangeToWhite()
    {
        PlayerPrefs.SetString("PlayerSprite", white);
    }

    public void ChangeToBlack()
    {
        PlayerPrefs.SetString("PlayerSprite", black);
    }
}
