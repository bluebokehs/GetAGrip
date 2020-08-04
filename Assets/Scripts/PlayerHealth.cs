using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;
    public float regenRate = 0.05f;

    public StaminaBar staminaBar;

    void Awake()
	{
        currentHealth = maxHealth;
        staminaBar.SetMaxHealth(maxHealth);
	}

    void Update()
	{

        // regenerate
        currentHealth += regenRate * Time.deltaTime;

        // checks bounds
        if (currentHealth > maxHealth)
        {
            currentHealth = 100;
        }
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        staminaBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
	{
        currentHealth -= damage;

        staminaBar.SetHealth(currentHealth);
    }
}
