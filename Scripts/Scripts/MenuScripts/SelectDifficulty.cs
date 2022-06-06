using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectDifficulty : MonoBehaviour
{

    private string Easy = "10";
    private string Normal = "20";
    private string Hard = "50";

    void Start()
    {
        
    }


    public void EasyMode()
    {
        
        string path = Application.dataPath + "/Difficulty.txt";
        
        File.WriteAllText(path, Easy);

        SceneManager.LoadScene("Final");

    }

    public void NormalMode()
    {
        string path = Application.dataPath + "/Difficulty.txt";

        File.WriteAllText(path, Normal);

        SceneManager.LoadScene("Final");
    }

    public void HardMode()
    {
        string path = Application.dataPath + "/Difficulty.txt";

        File.WriteAllText(path, Hard);

        SceneManager.LoadScene("Final");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    
    void CreateText()
    {
        //Path of the file
        string path = Application.dataPath + "/Difficulty.txt";
        //CreateFile if dont exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "difficulyulog");
        }
        //Content of the file
        
    }

    






}