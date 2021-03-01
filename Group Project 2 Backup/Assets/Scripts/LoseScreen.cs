using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
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

    void Update()
    {
        if (Input.GetButtonDown("A Button"))
        {
            SceneManager.LoadScene("Menus");
        }
        if (Input.GetButtonDown("B Button"))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}

