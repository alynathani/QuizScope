using System.Collections.Generic;
using UnityEngine;

// Make a Question asset accessible from the unity editor menu
[CreateAssetMenu(fileName = "New Question", menuName = "Question/CreateNewQuestion")]

// Derive from ScriptableObject
public class Question1 : ScriptableObject
{
    // The question
    public string QuestionContent;

    // Answer A 
    public string answerA;

    // Answer B
    public string answerB;

    // Answer C
    public string answerC;

    // Is Answer A the correct answer
    public bool isA;

    // Is Answer B the correct answer
    public bool isB;

    // Is Answer C the correct answer
    public bool isC;
}