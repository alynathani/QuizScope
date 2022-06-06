using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "REALQuestion/CreateQuestionREAL")]
public class Question : ScriptableObject {

    public string fact;
    public string answerA;
    public string answerB;
    public string answerC;
    public bool isA;
    public bool isB;
    public bool isC;


}
