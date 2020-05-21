using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragForce : MonoBehaviour
{
    public float power = 2f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    public double multiplier = 1.5;

    Camera camera;
    Vector3 camOffset = new Vector3(0, 0, 15);
    Vector2 force;

    Vector3 startPos;
    Vector3 endPos;
    Vector3 placeHoldPos;

    public TrajectoryLine tl;
    public PlayerHealth ph;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        tl = GetComponent<TrajectoryLine>();
    }

    // Update is called once per frame
    void Update()
    {
        // check for a single touch 
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            // when the finger hits the screen
            if (touch.phase == TouchPhase.Began)
            {
                startPos = camera.ScreenToWorldPoint(touch.position) + camOffset;
            }
            // when the finger drags across the screen
            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 currentPos = camera.ScreenToWorldPoint(touch.position) + camOffset;
                tl.RenderLine(startPos, currentPos);
            }
            // when the finger leaves the screen
            if (touch.phase == TouchPhase.Ended)
            {
                endPos = camera.ScreenToWorldPoint(touch.position) + camOffset;

                force = new Vector2(Mathf.Clamp(startPos.x - endPos.x, minPower.x, maxPower.x), Mathf.Clamp(startPos.y - endPos.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);

                ph.TakeDamage((int) Convert.ToDouble(Math.Abs(force.y * multiplier)));

                tl.EndLine();
            }
        }
    }
}
