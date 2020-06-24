using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glue : MonoBehaviour
{
    protected Transform stuckTo = null;
    protected Vector3 offset = Vector3.zero;
    GameObject hold;
 

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
        var col = hold.GetComponent<CircleCollider2D>();
        col.isTrigger = false;
    }

    public void DettachObject (GameObject other)
	{
        // make climber dynamic
        var rb = other.GetComponent<Rigidbody2D>();
        rb.isKinematic = false;

        stuckTo = null;

        // finds parent object (hold)
        hold = this.transform.parent.gameObject;

        // makes a hold a trigger in order to pass through the hold
        var col = hold.GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    IEnumerator MakeTriggerFalse(Collider2D collision)
	{
        collision.isTrigger = true;
        yield return new WaitForSeconds(5f);
        Debug.Log("test");
        collision.isTrigger = false;
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
