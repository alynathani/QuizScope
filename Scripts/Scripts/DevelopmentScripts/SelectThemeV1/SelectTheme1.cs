using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectTheme1 : MonoBehaviour
{
    // topics assigned to a string variable
    private string EnglishQ = "English";
    private string HistoryQ = "History";
    private string GeographyQ = "Geography";

    void Start()
    {
        // cursor is visible
        Cursor.visible = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;
    }

    // called when English button is pressed
    public void English()
    {
        // path of the text file
        string path = Application.dataPath + "/Log.txt";
        
        // write English to text file
        File.WriteAllText(path, EnglishQ);

        // load select difficulty scene
        SceneManager.LoadScene("SelectDifficultyV1");
    }

    // called when History button is pressed
    public void History()
    {
        // path of the text file
        string path = Application.dataPath + "/Log.txt";

        // write English to text file
        File.WriteAllText(path, HistoryQ);

        // load select difficulty scene
        SceneManager.LoadScene("SelectDifficultyV1");
    }

    // called when Geography button is pressed
    public void Geography()
    {
        // path of the text file
        string path = Application.dataPath + "/Log.txt";

        // write English to text file
        File.WriteAllText(path, GeographyQ);

        // load select difficulty scene
        SceneManager.LoadScene("SelectDifficultyV1");
    }

    // called when Back button is pressed
    public void BackMenu()
    {
        // load Main Menu scene
        SceneManager.LoadScene("MainMenuV1");
    }
}

