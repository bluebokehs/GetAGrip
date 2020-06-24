using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.9f;
    public float offset;

    private Vector3 currentVel;

    // Update is called once per frame
    void FixedUpdate()
    {
        // brings camera up higher
        if (target.position.y + offset > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y + offset, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVel, smoothSpeed * Time.deltaTime);
        }

        // if the player falls below camera, game over
        if (target.position.y < transform.Find("Edge").position.y)
		{
            FindObjectOfType<GameManager>().EndGame();
		}
    }
}
