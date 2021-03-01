using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Menus");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
       
      
}

