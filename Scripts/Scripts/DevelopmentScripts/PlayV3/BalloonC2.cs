using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BalloonC2 : MonoBehaviour
{
    // import GameManager2 script
    public GameManager4 _gameManager;

    // Set Balloon health
    public int ObjectHealth = 0;

    private string DifficultyString;
    private int DifficultyInt;

    // TakeDamage function
    void TakeDamage(int DamageAmount)
    {
        // Subtract DamageAmount from Balloon health
        ObjectHealth -= DamageAmount;
    }

    void Start()
    {
        UpdateDifficulty();
        ObjectHealth = DifficultyInt;
    }

    void Update()
    {
        // if the balloon health is less than or equal to 0
        if (ObjectHealth <= 0)
        {
            // Destroy the balloon
            Destroy(gameObject);

            // Call UserSelectA function from GameManager2
            _gameManager.UserSelectC();


        }
    }

    // Function called when the balloon collides with an object
    void OnCollisionEnter(Collision col)
    {
        // Destroy the balloon
        Destroy(gameObject);
        _gameManager.Transition();

    }

    void UpdateDifficulty()
    {
        string path = Application.dataPath + "/Difficulty.txt";
        StreamReader reader = new StreamReader(path);
        DifficultyString = reader.ReadToEnd();
        DifficultyInt = int.Parse(DifficultyString);
    }
}