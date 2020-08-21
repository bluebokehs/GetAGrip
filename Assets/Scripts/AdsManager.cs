using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class AdsManager : Singleton<AdsManager>
{
    public static AdsManager adsManager;

    string gameID = "3727190";
    public string myVideoPlacement = "video";
    public bool adStarted;
    public bool testMode = true;

    bool hasPaid = false;
    int adCount = 0;
    public int adRate = 4;

    void Awake()
    {
        if (adsManager == null)
        {
            DontDestroyOnLoad(this.gameObject);
            adsManager = this;
        }
        else if (adsManager != this)
        {
            Destroy(this.gameObject);
        }
        adsManager.Load();
    }

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID, testMode);
    }

    public void RemoveAds()
    {
        hasPaid = true;
    }

    // use after implementing coins!
    public void AddCoins(int amount)
    {
        //coinAmount += amount;
        //coinAmountText.text = coinAmount.ToString();
    }

    void Update()
    {
        if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted && (adCount % adRate == 0) && !hasPaid && SceneManager.GetActiveScene().name != "Menu")
        {
            Advertisement.Show(myVideoPlacement);
            adStarted = true;
        }
    }

    public void Save()
    {
        // create a file
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/adInfo.dat");
        
        PaidData data = new PaidData();
        data.hasPaid = hasPaid;

        // push data to file
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/adInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/adInfo.dat", FileMode.Open);
            PaidData data = (PaidData) bf.Deserialize(file);
            file.Close();

            hasPaid = data.hasPaid;
        }
    }

    

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "EndlessMode")
        {
            adCount += 1;
        }
    }

    // called when the game is terminated
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

[Serializable]
class PaidData
{
    public bool hasPaid;
}
