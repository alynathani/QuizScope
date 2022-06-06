using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using System.IO;

public class PauseMenu1 : MonoBehaviour
{
    // import GameManager script
    public GameManager4 _gameManager;

    // import GlobalAmmo script
    public GlobalAmmo1 _globalAmmo;

    // import GunMechanics object
    public GameObject GunMechanics;

    // import gun(M9) object
    public GameObject M9;

    // Set Pause state as false
    public static bool GameIsPaused = false;

    // import PauseMenu UI object
    public GameObject PauseMenuUI;

    // import FPSController script
    public Transform Player;



    void Start()
    {
        // audio is not paused
        AudioListener.pause = false;

        // cursor is visible
        Cursor.visible = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        // if the escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // if the game is paused
            if (GameIsPaused)
            {
                //resume playing scene
                Resume();
            }
            else
            {
                // pause the game
                Pause();
            }
        }
    }

    public void Resume()
    {
        // pause menu UI disappears
        PauseMenuUI.SetActive(false);

        // set time to normal
        Time.timeScale = 1f;

        // Enable FPSController script
        Player.GetComponent<FirstPersonController>().enabled = true;

        // Enable GunDamage script
        GunMechanics.GetComponent<GunDamage2>().enabled = true;

        // Enable FireGun script
        M9.GetComponent<FireGun2>().enabled = true;

        // Game is not paused
        GameIsPaused = false;

        // cursor is not visible
        Cursor.visible = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;

        // audio is not paused
        AudioListener.pause = false;
    }

    void Pause()
    {
        // pause menu UI appears
        PauseMenuUI.SetActive(true);

        // pause time
        Time.timeScale = 0f;

        // disable FPSController script
        Player.GetComponent<FirstPersonController>().enabled = false;

        // disable GunDamage script
        GunMechanics.GetComponent<GunDamage2>().enabled = false;

        // disable FireGun script
        M9.GetComponent<FireGun2>().enabled = false;

        // game is paused
        GameIsPaused = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;

        // audio is paused
        AudioListener.pause = true;
    }

    public void LoadMenu()
    {
        // reset question list
        _gameManager.SetUnanswerToNull();

        // reset score
        _gameManager.SetScoreToNull();

        // Load Menu Scene
        SceneManager.LoadScene("MenuSceneV1");

        // Set time to normal
        Time.timeScale = 1f;

        // cursor is visible
        Cursor.visible = true;

        // Set ammo to full capacity
        _globalAmmo.ResetAmmo();
    }

    public void QuitGame()
    {
        // print quitting game to console
        Debug.Log("Quitting Game...");

        // Quit game
        Application.Quit();
    }
}
