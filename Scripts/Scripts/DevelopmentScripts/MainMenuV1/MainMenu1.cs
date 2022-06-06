using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu1 : MonoBehaviour
{
    void Start()
    {
        // cursor is visible
        Cursor.visible = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;
    }

    // play game function
    public void PlayGame()
    {
        // load select theme scene
        SceneManager.LoadScene("SelectThemeV1");
    }

    // quit game function
    public void QuitGame()
    {
        // print Quit to console
        Debug.Log("QUIT!");

        // quit game
        Application.Quit();
    }


}
