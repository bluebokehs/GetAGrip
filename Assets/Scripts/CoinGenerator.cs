using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinGenerator : MonoBehaviour
{
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    public GameObject[] coins;
    public List<GameObject> objects = new List<GameObject>();

    Vector3 spawnPosition = new Vector3(0f,-1f,0f);

    // run before environment created
    void Awake()
    {
        coins = Resources.LoadAll<GameObject>("Coins");
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            objects.Add(Instantiate(coins[Random.Range(0,4)], spawnPosition, Quaternion.identity) as GameObject);
        }
    }

    public void RemoveObject(GameObject objectToRemove)
    {
        int index = objects.IndexOf(objectToRemove);
        for (int i = 0; i <= index; i++)
        {
            GameObject temp = objects[i];
            Destroy(temp);

            AddObject();
        }
        objects.RemoveRange(0, index + 1);
    }

    public void AddObject()
    {

        spawnPosition.y += Random.Range(minY, maxY);
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);

        objects.Add(Instantiate(coins[Random.Range(0, 4)], spawnPosition, Quaternion.identity) as GameObject);
    }
}
