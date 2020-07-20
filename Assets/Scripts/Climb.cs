using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Climb : MonoBehaviour
{
    public float waitTime = 0;

    public Animator animator;

    public GameObject ground;

    public DragForce dragForce;

    // Update is called once per frame
    void Update()
    {
        

        //animate
        StartCoroutine(Animate());
    }

    void CreateGlue(Vector3 position, GameObject other)
    {
        if (other != ground)
		{
            var glue = (new GameObject("glue")).AddComponent<Glue>();

            // glue position at the contact point
            glue.transform.position = position;

            // We make the object we collided with a parent of glue object
            glue.transform.SetParent(other.transform);

            // And now we call glue initialization
            glue.AttachObject(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // On collision we simply create a glue object at any contact point.
        dragForce.isAttached = true;
        if (col.gameObject.tag == "Hold")
        {
            CreateGlue(col.contacts[0].point, col.gameObject);
        }
    }

    IEnumerator Animate()
	{
        //animator
        animator.SetBool("isJumping", true);
        yield return new WaitForSeconds(waitTime);
    }
}
