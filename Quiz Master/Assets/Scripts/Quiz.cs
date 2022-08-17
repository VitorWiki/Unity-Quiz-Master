using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    void Start()
    {
        DisplayQuestion();
    }

    public void OnAnswerSelected(int index) 
    {
        Image buttonImage;

        if(index == question.getCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }

        else
        {
            questionText.text = "Wrong! The correct answer was\n" + question.getAswer(question.getCorrectAnswerIndex());
            buttonImage = answerButtons[question.getCorrectAnswerIndex()].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }

        SetButtonState(false);
    }

    void GetNextQuestion()
    {
        SetButtonState(true);
        SetDefaultButtonSprites();
        DisplayQuestion();
    }

    void DisplayQuestion() 
    {
        questionText.text = question.getQuestion();

        for (int index = 0; index < answerButtons.Length; index++) 
        {
            TextMeshProUGUI buttonText = answerButtons[index].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.getAswer(index);
        }
    }

    void SetButtonState(bool state)
    {
        for(int index = 0; index < answerButtons.Length; index++)
        {
            Button button = answerButtons[index].GetComponent<Button>();
            button.interactable = state;
        }
    }

    void SetDefaultButtonSprites()
    {
        for(int index = 0; index < answerButtons.Length; index++)
        {
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }
}
