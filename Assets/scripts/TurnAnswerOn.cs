using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAnswerOn : MonoBehaviour
{
    [SerializeField] GameObject answer;

    public void Show_Answer()
    {
        answer.SetActive(true);
    }
}
