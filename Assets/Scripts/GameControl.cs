using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public Text highScore;
    public int score = 0;
    public float time = 0;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(this.gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(this.gameObject);
        }
        control.Load();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            if (highScore == null)
            {
                highScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
            }
            highScore.text = score.ToString();
        }
    }

    public void Save()
    {
        // create a file
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        
        PlayerData data = new PlayerData();
        data.score = score;
        data.time = time;

        // push data to file
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData) bf.Deserialize(file);
            file.Close();

            time = data.time;
            score = data.score;
        }
    }
}

[Serializable]
class PlayerData
{
    public int score;
    public float time;
}
