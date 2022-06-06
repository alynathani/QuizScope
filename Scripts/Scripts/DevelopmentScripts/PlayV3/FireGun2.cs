using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun2 : MonoBehaviour
{
    void Update()
    {
        // if the current ammo in the gun is more than or equal to 1
        if (GlobalAmmo1.LoadedAmmo >= 1) 
        {
            // if the user presses the left mouse button
            if (Input.GetButtonDown("Fire1")) 
            {
                // Play recoil animation
                GetComponent<Animation>().Play("GunShot");

                // Decrease current ammo by 1
                GlobalAmmo1.LoadedAmmo -= 1;
            }
        }
    }
}