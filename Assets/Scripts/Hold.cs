using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public string holdName;
    public string description;

    public int staminaCost;
    public int degrationTime;

    SpriteRenderer holdSprite;
    ParticleSystem debris;

    DragForce dragForce;
    HoldGenerator holdGenerator;
    Rigidbody2D rb;
    PlayerHealth playerStamina;
    

    void Start()
    {
        holdSprite = this.GetComponent<SpriteRenderer>();
        debris = this.GetComponent<ParticleSystem>();

        dragForce = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();
        holdGenerator = GameObject.FindGameObjectWithTag("Generator").GetComponent<HoldGenerator>();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        playerStamina = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    public void RemoveObject()
    {
        holdGenerator.RemoveObject();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (degrationTime > 0)
        {
            StartCoroutine(Degrade(degrationTime));
        }
        if (staminaCost > 0)
        {
            StartCoroutine(StaminaReduce(staminaCost));
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        RemoveObject();
    }

    IEnumerator Degrade(int waitTime)
    {
        if (debris != null)
        {
            debris.Play();
        }

        yield return new WaitForSeconds(waitTime);
        RemoveObject();

        // make climber not kinematic
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    IEnumerator StaminaReduce(int stamina)
    {
        while (true)
		{
            if (playerStamina.currentHealth > 0)
            {
                playerStamina.currentHealth -= stamina;
            }
            yield return new WaitForSeconds(1);
        }
    }
}