using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage1 : MonoBehaviour
{
    // variable for the amount of health points the object has
    public int ObjectHealth = 10;

    // TakeDamage function, takes amount as parameter
    public void TakeDamage (int amount)
    {
        // reduce the object health by the damage amount
        ObjectHealth -= amount;

        // if the object health is less than or equal to 0
        if (ObjectHealth <= 0)
        {
            // calls Die() function
            Die();
        }

    }

    // Die function
    void Die()
    {
        // Destroy the object
        Destroy(gameObject);
    }
}