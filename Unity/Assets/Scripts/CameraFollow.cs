using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (target.position.y > transform.position.y)
        //{
        //    Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
        //    transform.position = newPos;
        //}

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        Vector3 newPos = new Vector3(transform.position.x, smoothedPosition.y, transform.position.z);
        transform.position = newPos;
    }
}
