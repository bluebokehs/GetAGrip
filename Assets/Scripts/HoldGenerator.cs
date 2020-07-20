using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldGenerator : MonoBehaviour
{
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    public GameObject[] holds;
    public Queue<GameObject> objects = new Queue<GameObject>();

    Vector3 spawnPosition = new Vector3(0f,-1f,0f);

    // run before environment created
    void Awake()
    {
        holds = Resources.LoadAll<GameObject>("Holds");
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            objects.Enqueue(Instantiate(holds[Random.Range(0,4)], spawnPosition, Quaternion.identity) as GameObject);
        }
    }

    public void RemoveObject()
    {
        Destroy(objects.Dequeue());
        AddObject();
    }

    public void AddObject()
    {
        spawnPosition.y += Random.Range(minY, maxY);
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);

        objects.Enqueue(Instantiate(holds[Random.Range(0, 4)], spawnPosition, Quaternion.identity) as GameObject);
    }
}
