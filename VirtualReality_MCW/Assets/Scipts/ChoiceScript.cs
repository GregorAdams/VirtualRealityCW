﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject Score;
    public GameObject Question;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;
    public bool finalchoice;
    public void ChoiceOption1()
    {
        Question.GetComponent<Text>().text = "Current Score";
        Question.GetComponent<Text>().text ="How did room 2 make you feel?";
        finalchoice = false;
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did room 3 make you feel?";
            ChoiceMade = ChoiceMade + 1;
            finalchoice = true;
        }
        if (ChoiceMade >= 6)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a strong possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 5 && ChoiceMade >=4)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a medium possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 3)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a low possibility that you may have Astraphobia";
        }
        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 1;
        }
    }
    public void ChoiceOption2()
    {
        Question.GetComponent<Text>().text ="How did room 2 make you feel?";
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did room 3 make you feel?";
            ChoiceMade = ChoiceMade + 2;
            finalchoice = true;
        }
        if (ChoiceMade >= 6)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a strong possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 5 && ChoiceMade >= 4)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a medium possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 3)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a low possibility that you may have Astraphobia";
        }

        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 2;
        }
    }
    public void ChoiceOption3()
    {
        Question.GetComponent<Text>().text ="How did room 2 make you feel?";
        if (ChoiceMade >= 1)
        {
            Question.GetComponent<Text>().text = "How did room 3 make you feel?";
            ChoiceMade = ChoiceMade + 3;
            finalchoice = true;
        }
        if (ChoiceMade >= 6)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a strong possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 5 && ChoiceMade >= 4)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a medium possibility that you may have Astraphobia";
        }
        if (ChoiceMade <= 3)
        {
            Score.GetComponent<Text>().text = "Your score suggest that there is a low possibility that you may have Astraphobia";
        }
        if (ChoiceMade == 0)
        {
            ChoiceMade = ChoiceMade + 3;
        }
    }
    public void FinalV()
    {
        return;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
