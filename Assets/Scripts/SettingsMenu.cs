using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMusic (float music)
	{
        audioMixer.SetFloat("music", music);
	}

    public void SetSFX (float sfx)
    {
        audioMixer.SetFloat("sfx", sfx);
    }
}
