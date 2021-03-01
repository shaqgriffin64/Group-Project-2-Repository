using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public  bool GameIsPaused = false;
    
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || (Input.GetButtonDown("Menu")))
        {
            
            
     
         Cursor.lockState = CursorLockMode.None;
           

          
               
 

            if (GameIsPaused)
            {
                Resume();
             
            }
            else
            {
                Pause();
            }
        



            
        
        
        
        
        }
        if (GameIsPaused)
        {
            if (Input.GetButtonDown("A Button"))
            {
                Resume(); 
            }
            if (Input.GetButtonDown("Jump"))
            {
                LoadMainMenu(); 
            }
            if (Input.GetButtonDown("B Button"))
            {
                QuitGame(); 
            }
        
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMainMenu()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menus");
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }
}
