using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCuttentBoard : MonoBehaviour
{
    [SerializeField] GameObject Current_board;
    [SerializeField] GameObject next_board;

    public void Switch_board()
    {
        Current_board.SetActive(false);
        next_board.SetActive(true);
    }
}
