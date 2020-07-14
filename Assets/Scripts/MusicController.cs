using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    public Sprite musicOnImage;
    public Sprite musicOffImage;
    public GameObject yourimage;
    public AudioMixer BGMusic;

    // Update is called once per frame
    public void ChangeMusicOnOffImage(bool on)
    {
        if(yourimage.GetComponent<Image>().sprite == musicOffImage)
        {
            BGMusic.SetFloat("music", 0);
            yourimage.GetComponent<Image>().sprite = musicOnImage;
        }
        else if (yourimage.GetComponent<Image>().sprite == musicOnImage)
        {
            BGMusic.SetFloat("music", -80);
            yourimage.GetComponent<Image>().sprite = musicOffImage;
        }
    }
}
