using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    CoinGenerator coinGenerator;

    // Start is called before the first frame update
    void Start()
    {
        coinGenerator = GameObject.FindGameObjectWithTag("CoinGenerator").GetComponent<CoinGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveObject()
    {
        if (SceneManager.GetActiveScene().name == "EndlessMode")
        {
            coinGenerator.RemoveObject(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
