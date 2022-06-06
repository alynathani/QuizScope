using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class GameOver1 : MonoBehaviour
{
    // ScoreText gameobject
    public Text ScoreText;

    // score string variable
    public string ScoreString;

    void Start()
    {
        // load final score from Play Scene
        LoadScore();

        // cursor is visible
        Cursor.visible = true;

        // cursor is not locked
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadScore()
    {
        // path of text file
        string path = Application.dataPath + "/Score.txt";

        // read the text file
        StreamReader reader = new StreamReader(path);

        // contents of text file assigned to ScoreString 
        ScoreString = reader.ReadToEnd();

        // score text object given value of final score
        ScoreText.text = ScoreString;
    }

    public void LoadMenu()
    {
        // load Main Menu
        SceneManager.LoadScene("MainMenuV1");
    }

}