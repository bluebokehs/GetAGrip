using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{

    string gameID = "3727190";
    public string myVideoPlacement = "video";
    public bool adStarted;
    public bool testMode = true;
    int adCount;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID, testMode);

        adCount = PlayerPrefs.GetInt("Ad Count");
    }

    public void AddToCount()
    {
        PlayerPrefs.SetInt("Ad Count", adCount + 1);
    }

    void Update()
    {
        if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted && (adCount % 3 == 0))
        {
            Advertisement.Show(myVideoPlacement);
            adStarted = true;
            
        }
    }
}
