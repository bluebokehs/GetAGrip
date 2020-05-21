using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glue : MonoBehaviour
{
    protected Transform stuckTo = null;
    protected Vector3 offset = Vector3.zero;

    public void AttachObject (GameObject other)
    {
        // make climber kinematic
        var rb = other.GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        // calculate offset
        offset = transform.position - other.transform.position;

        stuckTo = other.transform;
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
