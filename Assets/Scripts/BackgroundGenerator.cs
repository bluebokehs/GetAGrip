using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    public GameObject[] backgrounds;
    Dictionary<float, GameObject> backgroundMap;

    public Queue<GameObject> objects = new Queue<GameObject>();
    public float count = 0;

    GameObject currentBackground;

    // Start is called before the first frame update
    void Awake()
    {
        backgrounds = Resources.LoadAll<GameObject>("Backgrounds");

        backgroundMap = new Dictionary<float, GameObject>();
        backgroundMap.Add(0f, backgrounds[0]);
        backgroundMap.Add(45f, backgrounds[1]);

        currentBackground = backgroundMap[0];

        GenerateBackground();
    }

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // checks to see if the player has reached a ceratin height above the previous backgrounds
        if (player.transform.position.y > count - 16)
        {
            // removes last background
            Destroy(objects.Dequeue());

            // if the player has reached a certain height, change the background
            foreach (float key in backgroundMap.Keys)
            {
                if (count > key)
                {
                    currentBackground = backgroundMap[key];
                }
            }

            // add that background to the top of the queue
            objects.Enqueue(Instantiate(currentBackground, new Vector3(0f, count, 0f), Quaternion.identity) as GameObject);
            count += currentBackground.GetComponent<SpriteRenderer>().bounds.size.y;
        }
    }

    public void GenerateBackground()
    {
        // creates five backgrounds to begin with
        for (int i = 0; i < 5; i++)
        {
            objects.Enqueue(Instantiate(backgrounds[0], new Vector3(0f, count, 0f), Quaternion.identity) as GameObject);
            count += currentBackground.GetComponent<SpriteRenderer>().bounds.size.y;
        }
    }
}
