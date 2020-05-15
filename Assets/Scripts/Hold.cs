using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{

    public GameObject edge;

    void Update()
    {
        //if hold goes below view, it gets destroyed to save on memory
        if(transform.position.y < edge.transform.position.y * 1.2)
		{
            Destroy(this.gameObject);
		}
    }
}