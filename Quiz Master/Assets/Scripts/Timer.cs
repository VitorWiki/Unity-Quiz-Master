using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public bool isAsweringQuestion;
    public float fillFraction;
    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer() 
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAsweringQuestion)
        {
            if(timerValue <= 0)
            {
                isAsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
            else
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
        }
        else
        {
            if(timerValue <= 0)
            {
                isAsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
            else
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        }
        
        Debug.Log(isAsweringQuestion + ": " + timerValue + " = " + fillFraction);
    }
}
