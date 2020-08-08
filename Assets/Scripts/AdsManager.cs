using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdsManager : Singleton<AdsManager>
{

    string gameID = "3727190";
    public string myVideoPlacement = "video";
    public bool adStarted;
    public bool testMode = true;

    bool hasPaid = false;
    int adCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID, testMode);
    }

    public void RemoveAds()
    {
        hasPaid = true;
    }

    public void RestorePurchase()
    {
        hasPaid = false;
    }

    // use after implementing coins!
    public void AddCoins(int amount)
    {
        //coinAmount += amount;
        //coinAmountText.text = coinAmount.ToString();
    }

    void Update()
    {
        if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted && (adCount % 4 == 0) && !hasPaid && SceneManager.GetActiveScene().name != "Menu")
        {
            Advertisement.Show(myVideoPlacement);
            adStarted = true;
            adCount += 1;
        }
    }
}
