using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gaaaaa : MonoBehaviour
{
public void OpenMenu()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("DayTwo");
    }
}
