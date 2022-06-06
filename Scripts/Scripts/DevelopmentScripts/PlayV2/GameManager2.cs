using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    // Make an array out of the attributes in the Question1 class
    // Assign this array to the variable 'questions'
    // Set this array to null
    public Question1[] questions = null;

    // Make a list of the Question1 class attributes
    public static List<Question1> unansweredQuestions;

    // The current question has the attributes of the Question1 class
    public Question1 currentQuestion;

    // GameObject holder for Question Text
    [SerializeField]
    private Text QuestionText;

    // Time between questions asked is 1 second
    [SerializeField]
    private float TimeBetweenQuestions = 1f;

    // GameObject holder for Answer A text
    [SerializeField]
    private Text AnswerAText;

    // GameObject holder for Answer B text
    [SerializeField]
    private Text AnswerBText;

    // GameObject holder for AnswerCText
    [SerializeField]
    private Text AnswerCText;

    // GameObject holder for CorrectText
    [SerializeField]
    private Text Correct;

    // GameObject holder for IncorrectText
    [SerializeField]
    private Text Incorrect;

    // This function is called before first frame
    void Start()
    {
        // Call LoadQuestions function
        LoadQuestions();

        // unansweredQuestions is a list made from the Question1 array
        unansweredQuestions = questions.ToList<Question1>();

        // Call SetCurrentQuestion function
        SetCurrentQuestion();
    }

    void SetCurrentQuestion()
    {
        // Assign variable to a random integer in the range of 0 to the element count of unansweredQuestions
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);

        // Set the current question to an element in unansweredQuestions
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        // Question Text given value of the current question
        QuestionText.text = currentQuestion.QuestionContent;

        // AnswerA Text given the value of the current AnswerA
        AnswerAText.text = currentQuestion.answerA;

        // AnswerB Text given the value of the current AnswerB
        AnswerBText.text = currentQuestion.answerB;

        // AnswerC Text given the value of the current AnswerC
        AnswerCText.text = currentQuestion.answerC;
    }

    // Function called when User selects AnswerA
    public void UserSelectA()
    {
        // If AnswerA is correct
        if (currentQuestion.isA)
        {
            // Display 'correct' text in on UI
            Correct.text = "Correct";

            // Display 'correct' in console
            Debug.Log("correct");
        }
        else
        {
            // Display 'incorrect' text in on UI
            Incorrect.text = "Incorrect";

            // Display 'wrong' in console
            Debug.Log("wrong");
        }
    }

    // Function called when User selects AnswerB
    public void UserSelectB()
    {
        // If AnswerB is correct
        if (currentQuestion.isB)
        {
            // Display 'correct' text in on UI
            Correct.text = "Correct";

            // Display 'correct' in console
            Debug.Log("correct");
        }
        else
        {
            // Display 'incorrect' text in on UI
            Incorrect.text = "Incorrect";

            // Display 'wrong' in console
            Debug.Log("wrong");
        }
    }

    // Function called when User selects AnswerC
    public void UserSelectC()
    {
        // If AnswerC is correct
        if (currentQuestion.isC)
        {
            // Display 'correct' text in on UI
            Correct.text = "Correct";

            // Display 'correct' in console
            Debug.Log("correct");
        }
        else
        {
            // Display 'incorrect' text in on UI
            Incorrect.text = "Incorrect";

            // Display 'wrong' in console
            Debug.Log("wrong");
        }
    }

    public void LoadQuestions()
    {
        // Make an object array out of the question objects stored in the 'English' folder
        // These objects must have the same form as the Question1 class
        object[] objs = Resources.LoadAll("English1", typeof(Question1));

        // questions is a new array given the length of the amount of objects in the theme folder
        questions = new Question1[objs.Length];

        // fill questions array with the theme questions
        for (int i = 0; i < objs.Length; i++)
        {
            questions[i] = (Question1)objs[i];
        }
    }

}