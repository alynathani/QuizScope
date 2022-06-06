using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectTheme : MonoBehaviour
{

    private string EnglishQ = "English";
    private string HistoryQ = "History";
    private string GeographyQ = "Geography";

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void English()
    {
        //Path of the file
        string path = Application.dataPath + "/Log.txt";
        //Add the text to it
        File.WriteAllText(path, EnglishQ);
        
        SceneManager.LoadScene("SelectDifficulty");
    }

    public void History()
    {
        //Path of the file
        string path = Application.dataPath + "/Log.txt";
        //Add the text to it
        File.WriteAllText(path, HistoryQ);
        
        SceneManager.LoadScene("SelectDifficulty");
    }

    public void Geography()
    {
        //Path of the file
        string path = Application.dataPath + "/Log.txt";
        //Add the text to it
        File.WriteAllText(path, GeographyQ);
        
        SceneManager.LoadScene("SelectDifficulty");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    /*
    void CreateText()
    {
        //Path of the file
        string path = Application.dataPath + "/Log.txt";
        //CreateFile if dont exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "");
        }
        //Content of the file
        
        //Add the text to it
        File.WriteAllText(path, English);
    }

    


    void Start()
    {
        CreateText();
    }
    */



}
