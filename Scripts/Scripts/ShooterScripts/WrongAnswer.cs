using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager _gameManager;
    public int EnemyHealth = 10;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            _gameManager.UserSelectA();

        }
    }
}
