using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject pauseMenuUI;
    

    // GetKeyUp    && GetButtonUp    Quando soltar a tecla
    // GetKeyDown  && GetButtonDown  Quando Precionar a tecla
    // GetKey      && GetButton      Enquanto pressionada

    void Start()
    {   
        Resume();
    }

    
    public void BackMenu()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("LobbyMenu");
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))     //KeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) 
            {
                Resume();
            } else 
            {
                Pause();
            }
        }
    }

    public void Resume() 
    {   
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {   
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        
    }

}

