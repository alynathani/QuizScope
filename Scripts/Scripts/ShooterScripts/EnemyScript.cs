using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int EnemyHealth = 10;

    void DeductPoints (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("DestroyedSphere");
        }
    }
}
