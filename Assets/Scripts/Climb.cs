using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Climb : MonoBehaviour
{
    public GameObject hold;

    public float number = 0;

    public float speed = 10f;

    public float waitTime = 0;

    public Vector2 targetposition;

    public GameObject target;

    public bool touch = true;

    public StaminaBar staminaBar;

    public Sprite blueImage;
    public Sprite redImage;

    public Animator animator;

    void Start()
	{
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isClimbing", false);
        GameObject hold = GameObject.Find("Hold(Clone)");

        if (hold.GetComponent<Collider2D>() == Physics2D.OverlapPoint(targetposition))
        {
            Vector2 holdPosition = new Vector2(hold.transform.position.x, hold.transform.position.y - 1);
            targetposition = holdPosition;
            hold.name = "Hold(Clone)" + number;
            number++;
            //animate
            StartCoroutine(Animate());

            //decides rest time
            if (staminaBar.slider.value != 50)
            {
                waitTime = Mathf.Abs(50 - staminaBar.slider.value) / 10;
                //rest
                StartCoroutine(Rest());
            }
        }
    }

    IEnumerator Animate()
	{
        //animator
        animator.SetBool("isClimbing", true);
        yield return new WaitForSeconds(waitTime);
    }

    IEnumerator Rest()
	{
        //disable touch
        touch = false;
        target.GetComponent<Image>().sprite = redImage;

        yield return new WaitForSeconds(waitTime);

        //enable touch
        touch = true;
        target.GetComponent<Image>().sprite = blueImage;
    }
}
