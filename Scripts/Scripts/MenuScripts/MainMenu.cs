using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None;
    }


    public void PlayGame()
    {
        
        SceneManager.LoadScene("SelectTheme");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    
}
