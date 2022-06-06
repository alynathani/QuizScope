using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonB1 : MonoBehaviour
{
    // import GameManager2 script 
    public GameManager3 _gameManager;

    // Set Balloon health
    public int ObjectHealth = 10;

    // TakeDamage function
    void TakeDamage(int DamageAmount)
    {
        // Subtract DamageAmount from Balloon health
        ObjectHealth -= DamageAmount;
    }

    void Update()
    {
        // if the balloon health is less than or equal to 0
        if (ObjectHealth <= 0)
        {
            // Destroy the balloon
            Destroy(gameObject);

            // Call UserSelectB function from GameManager2
            _gameManager.UserSelectB();


        }
    }

    // Function called when the balloon collides with an object
    void OnCollisionEnter(Collision col)
    {
        // Destroy the balloon
        Destroy(gameObject);

    }
}
