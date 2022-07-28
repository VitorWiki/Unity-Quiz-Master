using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string getQuestion()
    {
        return question;
    }

    public int getCorrecAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string getAswer(int index)
    {
        return answers[index];
    }
}
