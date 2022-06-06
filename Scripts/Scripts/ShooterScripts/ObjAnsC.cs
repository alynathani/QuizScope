using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ObjAnsC : MonoBehaviour
{
    
    public GameManager _gameManager;
    public int EnemyHealth = 10;

    private string difficulty;
    private int difficultyint;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Start()
    {
        readFile();
        EnemyHealth = difficultyint;
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            _gameManager.UserSelectC();
            
            


        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        _gameManager.Transition();
    }

    void readFile()
    {
        string path = Application.dataPath + "/Difficulty.txt";

        StreamReader reader = new StreamReader(path);

        difficulty = reader.ReadToEnd();

        difficultyint = int.Parse(difficulty);

    }
}