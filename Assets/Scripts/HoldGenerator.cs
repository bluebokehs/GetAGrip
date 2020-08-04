using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoldGenerator : MonoBehaviour
{
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    public GameObject[] holds;
    public List<GameObject> objects = new List<GameObject>();

    Vector3 spawnPosition = new Vector3(0f,-1f,0f);
    Vector3 tutPosition = new Vector3(0f, 5f, 0f);

    public TutorialManager tutManager;

    // run before environment created
    void Awake()
    {
        holds = Resources.LoadAll<GameObject>("Holds");
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            spawnPosition = tutPosition;
            objects.Add(tutManager.jug);
            objects.Add(tutManager.jug1);
            objects.Add(tutManager.pinch);
            objects.Add(tutManager.sloper);
        }

        for (int i = 0; i < 5; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            objects.Add(Instantiate(holds[Random.Range(0,4)], spawnPosition, Quaternion.identity) as GameObject);
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

        objects.Add(Instantiate(holds[Random.Range(0, 4)], spawnPosition, Quaternion.identity) as GameObject);
    }
}
