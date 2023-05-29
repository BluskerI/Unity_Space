using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int number;

    public void StartGame()
    {

        SceneManager.LoadScene(number);

    }

    public void Exit()
    {
        Application.Quit();
    }

}
