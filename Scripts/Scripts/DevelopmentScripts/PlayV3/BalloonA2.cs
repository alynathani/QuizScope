using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BalloonA2 : MonoBehaviour
{
    // import GameManager2 script
    public GameManager4 _gameManager;

    // Set Balloon health
    public int ObjectHealth = 0;

    // string variable
    private string DifficultyString;

    // integer variable
    private int DifficultyInt;

    // TakeDamage function
    void TakeDamage(int DamageAmount)
    {
        // Subtract DamageAmount from Balloon health
        ObjectHealth -= DamageAmount;
    }

    void Start()
    {
        // update the difficulty
        UpdateDifficulty();

        // object health updated to difficulty
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
            _gameManager.UserSelectA();


        }
    }

    // Function called when the balloon collides with an object
    void OnCollisionEnter(Collision col)
    {
        // Destroy the balloon
        Destroy(gameObject);

        // load next question
        _gameManager.Transition();

    }

    void UpdateDifficulty()
    {
        // path of text file
        string path = Application.dataPath + "/Difficulty.txt";

        // reader path
        StreamReader reader = new StreamReader(path);

        // assign contents of text file to string variable
        DifficultyString = reader.ReadToEnd();

        // assign strig variable to integer variable
        DifficultyInt = int.Parse(DifficultyString);
    }
}
