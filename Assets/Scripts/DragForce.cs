using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

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

    TrajectoryLine tl;
    PlayerHealth ph;

    public Slider stamina;

    GameObject glueObject;
    public bool isAttached = true;
    public bool touchUI = false;

    public AudioSource jumpSound;

    public Animator animator;
    public RuntimeAnimatorController white;
    public RuntimeAnimatorController black;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        tl = GetComponent<TrajectoryLine>();
        ph = GetComponent<PlayerHealth>();
        glueObject = null;

        if (PlayerPrefs.GetString("PlayerSprite") == "white")
        {
            animator.runtimeAnimatorController = white;
        }
        else if (PlayerPrefs.GetString("PlayerSprite") == "black")
        {
            animator.runtimeAnimatorController = black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Clamp(GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity.y, -1, 1);

        // check for a single touch 
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (isAttached == true && touchUI == false)
            {
                // when the finger hits the screen
                if (touch.phase == TouchPhase.Began)
                {
                    // records the starting position of the drag
                    startPos = camera.ScreenToWorldPoint(touch.position) + camOffset;
                }
                // when the finger drags across the screen
                if (touch.phase == TouchPhase.Moved)
                {
                    // renders the current position of the drag to the screen
                    Vector3 currentPos = camera.ScreenToWorldPoint(touch.position) + camOffset;
                    tl.RenderLine(startPos, currentPos);
                }
                // when the finger leaves the screen
                if (touch.phase == TouchPhase.Ended)
                {
                    // assigns value to the glue that is currently attached to the hold that the climber is on top of
                    glueObject = GameObject.Find("glue");

                    // if the glue is attached, then detach and destroy the glue
                    if (glueObject != null)
                    {
                        glueObject.GetComponent<Glue>().DettachObject(gameObject);
                        Destroy(glueObject);
                        isAttached = false;
                    }
                    else if (glueObject == null)
                    {
                        isAttached = true;
                    }

                    // records final position 
                    endPos = camera.ScreenToWorldPoint(touch.position) + camOffset;

                    // creates the force output
                    force = new Vector2(Mathf.Clamp(startPos.x - endPos.x, minPower.x, maxPower.x), Mathf.Clamp(startPos.y - endPos.y, minPower.y, maxPower.y));
                    int damage = (int)Convert.ToDouble(Math.Abs(force.y * multiplier));

                    // checks to see if there is enough stamina, then moves and takes stamina
                    if (damage <= stamina.value)
                    {
                        rb.AddForce(force * power, ForceMode2D.Impulse);
                        ph.TakeDamage(damage);
                    }
                    
                    // plays jump sound
                    StartCoroutine(FinishSound());

                    tl.EndLine();
                }
            }
        }

        if (isAttached)
        {
            animator.SetBool("isJumping", false);
        }
        else
        {
            animator.SetBool("isJumping", true);
        }

        touchUI = false;

    }

    IEnumerator FinishSound()
    {
        jumpSound.Play();
        yield return new WaitForSeconds(jumpSound.clip.length);
    }
}
