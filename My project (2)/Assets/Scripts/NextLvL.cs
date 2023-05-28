using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvL : MonoBehaviour
{
    public int number = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ruh>() != null)
        {
            SceneManager.LoadScene(number);
        }
    }
   
}
