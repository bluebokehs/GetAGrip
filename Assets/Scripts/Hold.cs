using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public string holdName;
    public string description;

    public SpriteRenderer holdSprite;

    public int staminaCost;
    public int degrationTime;

    DragForce dragForce;

    HoldGenerator holdGenerator;

    void Start()
    {
        holdSprite = this.GetComponent<SpriteRenderer>();
        dragForce = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();

        holdGenerator = GameObject.FindGameObjectWithTag("Generator").GetComponent<HoldGenerator>();
    }

    public void RemoveObject()
    {
        holdGenerator.RemoveObject();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (degrationTime > 0)
        {
            //StartCoroutine(Degrade(degrationTime));
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        RemoveObject();
    }

    IEnumerator Degrade(int waitTime)
    {
        Debug.Log("before");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("after");
        RemoveObject();
        Debug.Log("removed");
    }
}