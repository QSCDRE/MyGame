using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlOne : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("scene");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("DayOne - Copy");
    }
}
