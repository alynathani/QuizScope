using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class GameOver : MonoBehaviour
{
    public Text ScoreText;

    public string ScoreString;

    void Start()
    {
        score();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void score()
    {
        string path = Application.dataPath + "/Score.txt";

        StreamReader reader = new StreamReader(path);

        ScoreString = reader.ReadToEnd();

        ScoreText.text = ScoreString;
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

}