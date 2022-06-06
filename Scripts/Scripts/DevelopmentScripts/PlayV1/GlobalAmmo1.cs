using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Unity module to enable UI manipulation through scripts

public class GlobalAmmo1 : MonoBehaviour
{
    public static int LoadedAmmo = 50; // create loaded ammo variable and set to 50
    public GameObject LoadedDisplay; // ammo text referenced for manipulation

    void Update()
    {
        LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo; // update ammo text according to number of ammo
    }

    public void ResetAmmo()
    {
        LoadedAmmo = 50;
    }
}