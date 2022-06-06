using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun1 : MonoBehaviour
{
    void Update()
    {
        if (GlobalAmmo1.LoadedAmmo >= 1) // if the current ammo in the gun is more than or equal to 1
        {
            if (Input.GetButtonDown("Fire1")) // if the user presses the left mouse button
            {
                GlobalAmmo1.LoadedAmmo -= 1; // decrease the current ammo by 1
            }
        }
    }
}