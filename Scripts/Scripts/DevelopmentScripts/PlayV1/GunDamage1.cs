using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage1 : MonoBehaviour
{
    // How much damage is dealt from the gun when it is fired
    public int DamageAmount = 10;

    // The range the gun can deal damage in
    public float AllowedRange = 1000.0f;

    // Get properties from a raycast
    private RaycastHit Shot; 

    // Assign variable to the first person camera
    public Camera fpsCam; 

    void Update()
    {
        // if the current ammo in the gun is more than or equal to 1
        if (GlobalAmmo1.LoadedAmmo >= 1)
        {
            // if the left mouse button is pressed
            if (Input.GetButtonDown("Fire1"))
            {
                // get information from raycast
                RaycastHit Shot;

                // check if raycast has hit anything
                if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out Shot))
                {
                    // output the object name the raycast hits in the console
                    Debug.Log(Shot.transform.name);

                    // assign 'target' name to TakeDamage1 script and obtain it
                    Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);


                }
            }
        }
    }
}