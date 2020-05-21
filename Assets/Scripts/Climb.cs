using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Climb : MonoBehaviour
{
    public float waitTime = 0;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isClimbing", false);

        //animate
        StartCoroutine(Animate());
    }

    void CreateGlue(Vector3 position, GameObject other)
    {
        var glue = (new GameObject("glue")).AddComponent<Glue>();

        // glue position at the contact point
        glue.transform.position = position;

        // We make the object we collided with a parent of glue object
        glue.transform.SetParent(other.transform);

        // And now we call glue initialization
        glue.AttachObject(gameObject);
    }

    void OnCollision2DEnter(Collision2D col)
    {
        // On collision we simply create a glue object at any contact point.
        CreateGlue(col.contacts[0].point, col.gameObject);

        Debug.Log("test");
    }

    IEnumerator Animate()
	{
        //animator
        animator.SetBool("isClimbing", true);
        yield return new WaitForSeconds(waitTime);
    }
}
