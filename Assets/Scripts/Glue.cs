using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Glue : MonoBehaviour
{
    protected Transform stuckTo = null;
    protected Vector3 offset = Vector3.zero;
    GameObject hold;

    public GameObject player;
    GameObject groundObject;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        groundObject = player.GetComponent<Climb>().ground;
    }

    public void AttachObject (GameObject other)
    {
        // make climber kinematic
        var rb = other.GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        // calculate offset
        offset = transform.position - other.transform.position;

        stuckTo = other.transform;

        // finds parent object (hold)
        hold = this.transform.parent.gameObject;

        // makes a hold a trigger in order to pass through the hold
        var col = hold.GetComponent<Collider2D>();
        col.isTrigger = false;

        other.GetComponent<Climb>().currentHold = hold;
    }

    public void DettachObject (GameObject other)
	{
        // make climber dynamic
        var rb = other.GetComponent<Rigidbody2D>();
        rb.isKinematic = false;

        stuckTo = null;
        
        // finds parent object (hold)
        hold = this.transform.parent.gameObject;

        if (hold != groundObject)
        {
            // makes a hold a trigger in order to pass through the hold
            var col = hold.GetComponent<Collider2D>();
            col.isTrigger = true;

            if (SceneManager.GetActiveScene().name == "EndlessMode" || SceneManager.GetActiveScene().name == "Tutorial")
            {
                GameObject.FindGameObjectWithTag("Generator").GetComponent<HoldGenerator>().RemoveObject(other.GetComponent<Climb>().currentHold);
            }
        }
        else
        {
            StartCoroutine(SetTrigger());
        }
    }

    IEnumerator SetTrigger()
    {
        print("test");
        // makes a hold a trigger in order to pass through the hold
        var col = hold.GetComponent<Collider2D>();
        col.isTrigger = true;

        yield return new WaitForSeconds(0.25f);

        col.isTrigger = false;

        Destroy(this.gameObject);
    }

    public void LateUpdate()
    {
        if (stuckTo != null)
		{
            // If you don't want to support rotation remove this line
            stuckTo.rotation = transform.rotation;

            stuckTo.position = transform.position - transform.rotation * offset;
		}
    }
}
