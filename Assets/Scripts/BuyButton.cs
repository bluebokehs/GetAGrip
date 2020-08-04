using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public enum ItemType
    {
        Coin50,
        NoAds
    }

    public ItemType itemType;

    public void ClickBuy()
    {
        switch(itemType)
        {
            case ItemType.Coin50:
                IAPManager.Instance.Buy50Coins();
                break;
            case ItemType.NoAds:
                IAPManager.Instance.BuyNoAds();
                break;
        }
    }
}
