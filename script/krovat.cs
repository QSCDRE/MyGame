using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class krovat : MonoBehaviour
{    public void OpenMenu()
    {
        SceneManager.LoadScene("DayOne - Copy");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }
}
