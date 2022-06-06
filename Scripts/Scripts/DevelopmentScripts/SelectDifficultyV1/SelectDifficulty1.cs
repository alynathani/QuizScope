using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectDifficulty1 : MonoBehaviour
{

    // easy variable
    private string Easy = "10";

    // normal variable
    private string Normal = "20";

    // hard variable
    private string Hard = "50";

    // easy mode function
    public void EasyMode()
    {
        // text file path
        string path = Application.dataPath + "/Difficulty.txt";

        // write 10 to text file
        File.WriteAllText(path, Easy);

        // load Play scene
        SceneManager.LoadScene("PlaySceneV4");

    }

    // normal mode function
    public void NormalMode()
    {
        // text file path
        string path = Application.dataPath + "/Difficulty.txt";

        // write 20 to text file
        File.WriteAllText(path, Normal);

        // load play scene
        SceneManager.LoadScene("PlaySceneV4");
    }

    // hard mode function
    public void HardMode()
    {
        // text file path
        string path = Application.dataPath + "/Difficulty.txt";

        // write 50 to text file
        File.WriteAllText(path, Hard);

        // load play scene
        SceneManager.LoadScene("PlaySceneV4");
    }

    // back function
    public void BackMenu()
    {
        // load main menu
        SceneManager.LoadScene("MainMenuV1");
    }
}