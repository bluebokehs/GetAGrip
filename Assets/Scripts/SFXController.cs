using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SFXController : MonoBehaviour
{
    public Sprite musicOnImage;
    public Sprite musicOffImage;
    public GameObject yourimage;
    public AudioMixer SFXMusic;

    // Update is called once per frame
    public void ChangeMusicOnOffImage(bool on)
    {
        if(yourimage.GetComponent<Image>().sprite == musicOffImage)
        {
            SFXMusic.SetFloat("sfx", 0);
            yourimage.GetComponent<Image>().sprite = musicOnImage;
        }
        else if (yourimage.GetComponent<Image>().sprite == musicOnImage)
        {
            SFXMusic.SetFloat("sfx", -80);
            yourimage.GetComponent<Image>().sprite = musicOffImage;
        }
    }
}
