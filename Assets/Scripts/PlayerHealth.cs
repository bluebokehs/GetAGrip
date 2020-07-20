using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;
    public float regenRate = 0.0000005f;
    public float waitTime = 1f;

    public StaminaBar staminaBar;

    void Start()
	{
        currentHealth = maxHealth;
        staminaBar.SetMaxHealth(maxHealth);
	}

    void Update()
	{
        if (currentHealth < maxHealth)
        {
            //StartCoroutine(Regen());
        }
        staminaBar.SetHealth(currentHealth);
    }

    IEnumerator Regen()
	{
        for (float health = currentHealth; health <= maxHealth; health += regenRate)
		{
            Debug.Log("regenerating");
            currentHealth = health;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        currentHealth = maxHealth;
	}

    public void TakeDamage(int damage)
	{
        currentHealth -= damage;

        staminaBar.SetHealth(currentHealth);
    }
}
