using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hold : MonoBehaviour
{
    public float staminaCost;
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

        if (SceneManager.GetActiveScene().name == "EndlessMode")
        {
            holdGenerator = GameObject.FindGameObjectWithTag("Generator").GetComponent<HoldGenerator>();
        }
        dragForce = GameObject.FindGameObjectWithTag("Player").GetComponent<DragForce>();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        playerStamina = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    public void RemoveObject()
    {
        if (SceneManager.GetActiveScene().name == "EndlessMode")
        {
            holdGenerator.RemoveObject();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (degrationTime > 0)
        {
            StartCoroutine(Degrade(degrationTime));
        }
        StartCoroutine(StaminaReduce(staminaCost));
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

    IEnumerator StaminaReduce(float stamina)
    {
        for (float currentStamina = playerStamina.currentHealth; currentStamina >= 0 && currentStamina <= 100; currentStamina -= stamina)
		{
            playerStamina.currentHealth = currentStamina;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}