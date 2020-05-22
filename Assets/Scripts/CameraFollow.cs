using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.9f;
    public Vector3 offset;

    private Vector3 currentVel;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVel, smoothSpeed * Time.deltaTime);
        }


        if (target.position.y < transform.FindChild("Edge").position.y)
		{
            FindObjectOfType<GameManager>().EndGame();
		}
    }
}
