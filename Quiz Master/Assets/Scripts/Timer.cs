using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectQuestion = 10f;

    public bool isAsweringQuestion = false;
    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAsweringQuestion)
        {
            if(timerValue <= 0)
            {
                isAsweringQuestion = false;
                timerValue = timeToShowCorrectQuestion;
            }
        }
        else
        {
            if(timerValue <= 0)
            {
                isAsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }
        
        Debug.Log(timerValue);
    }
}
