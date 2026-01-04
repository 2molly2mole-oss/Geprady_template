using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Question;
    [SerializeField] GameObject button;

    public void LoadQuestion()
    {
        button.SetActive(false);
        Main.SetActive(false);
        Question.SetActive(true);
    }
}
