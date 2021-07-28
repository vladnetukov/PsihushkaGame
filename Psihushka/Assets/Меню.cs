using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Меню : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Уровень 1");
    }

    public void ExitGame()
    {
       
        Application.Quit();
    }
}
