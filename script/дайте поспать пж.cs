using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class дайтепоспатьпж : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("DayTwo");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
