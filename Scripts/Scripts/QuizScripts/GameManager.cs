using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{

    
    public Question[] questions = null;
    public static List<Question> unansweredQuestions;
    public Question currentQuestion;

    public GameObject GunMechanics;
    public GameObject M9;

    private string name;


    [SerializeField]
    private Text factText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    [SerializeField]
    private Text AnswerAText;

    [SerializeField]
    private Text AnswerBText;

    [SerializeField]
    private Text AnswerCText;

    [SerializeField]
    private Text Correct;

    [SerializeField]
    private Text Incorrect;


    public static int ScoreValue;
    public Text ScoreText;
    public string ScoreString;

    

    void Start()
    {
        readFile();
        LoadQuestions();
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();

        QuestionTotal();

    }

    void Update()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            
            Debug.Log("All questions answered");
            WriteScoreToDoc();
            setUnansToNull();
            SetScoreToNull();
            Time.timeScale = 1f;
            Cursor.visible = true;
            SceneManager.LoadScene("GameOver");

        }
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
        AnswerAText.text = currentQuestion.answerA;
        AnswerBText.text = currentQuestion.answerB;
        AnswerCText.text = currentQuestion.answerC;

    }


    void QuestionTotal()
    {
        ScoreText.text = ScoreValue.ToString();
    }


    public IEnumerator TransitionToNextQuestion()
    {

        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);

        QuestionTotal();
        Debug.Log(ScoreValue);
        SceneManager.LoadScene("Final");

    }

    public void Transition()
    {
        StartCoroutine(TransitionToNextQuestion());
    }


    public void UserSelectA()
    {
        GunMechanics.GetComponent<GunDamage>().enabled = false;
        M9.GetComponent<GunFire>().enabled = false;
        if (currentQuestion.isA)
        {
            Debug.Log("correct");
            ScoreValue += 1;
            Correct.text = "Correct";
            

        }
        else
        {
            Debug.Log("wrong");
            Incorrect.text = "Incorrect";
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectB()
    {
        GunMechanics.GetComponent<GunDamage>().enabled = false;
        M9.GetComponent<GunFire>().enabled = false;
        if (currentQuestion.isB)
        {
            Debug.Log("correct");
            ScoreValue += 1;
            Correct.text = "Correct";


        }
        else
        {
            Debug.Log("wrong");
            Incorrect.text = "Incorrect";
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectC()
    {
        GunMechanics.GetComponent<GunDamage>().enabled = false;
        M9.GetComponent<GunFire>().enabled = false;
        if (currentQuestion.isC)
        {
            Debug.Log("correct");
            ScoreValue += 1;
            Correct.text = "Correct";


        }
        else
        {
            Debug.Log("wrong");
            Incorrect.text = "Incorrect";
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    void readFile()
    {
        string path = Application.dataPath + "/Log.txt";

        StreamReader reader = new StreamReader(path);

        name = reader.ReadToEnd();

        

    }

    public void setUnansToNull()
    {
        unansweredQuestions = null;
    }

    public void SetScoreToNull()
    {
        ScoreValue = 0;
    }

    public void LoadQuestions()
    {
        Object[] objs = Resources.LoadAll(name, typeof(Question));
        questions = new Question[objs.Length];
        for (int i = 0; i < objs.Length; i++)
        {
            questions[i] = (Question)objs[i];
        }
    }

    public void WriteScoreToDoc()
    {
        string path = Application.dataPath + "/Score.txt";

        ScoreString = ScoreValue.ToString();

        File.WriteAllText(path, ScoreString);

        
    }
    
}


