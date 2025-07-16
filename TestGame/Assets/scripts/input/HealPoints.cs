using Assets.scripts.input;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealPoints : MonoBehaviour, IDamage
{
    private float maxHealth = 100;
    private float currentHealth = 100;
    public UnityEvent onDeath;
    [SerializeField]private Slider healthBar;

    

    public float GetHealth()
    {
        return currentHealth;
    }

    public void TakeDamage(float amount)
    {

        currentHealth -= amount;
        float value = currentHealth / maxHealth;
        healthBar.value = value;
        if(currentHealth <= 0 )
        {
            onDeath?.Invoke();
        }

    }



  
}
