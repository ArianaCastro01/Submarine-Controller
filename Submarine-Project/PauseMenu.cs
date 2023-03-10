using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public bool GameIsPaused = false;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) //when escape key is pressed

        {
            if (GameIsPaused == false)
            {
                GameIsPaused = true;
                pauseMenuUI.SetActive(true);
            }
            
            else
            {
                GameIsPaused = false;
                pauseMenuUI.SetActive(false);
            }

            
           /* if (GameIsPaused)
            { Resume(); }
            else
            { Pause(); }         //Pause & Resume are not Unity functions, we need to write them */
            
        } 


    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); //shows the pause menu and its child objects, the panels & buttons
        Time.timeScale = 0f;  //freezes time in the game world, effectively pausing
       GameIsPaused = true;  //we use this boolean to track if the game is paused

    }

    public void Resume(bool tf)
    {
        pauseMenuUI.SetActive(false); //hides the pause menu

        Time.timeScale = 1f;  //starts time in the game world
        GameIsPaused = tf;  //we use this boolean to track if the game is paused
        Debug.Log("Resuming...");
    }

    public void LoadMenu(bool tf)
    {
        Time.timeScale = 1f;
        GameIsPaused = tf;
        Debug.Log("Loading Menu...");
        //SceneManager.LoadScene("Menu");
    }
    public void QuitGame(bool tf)
    {
        pauseMenuUI.SetActive(false); //hides the pause menu
        GameIsPaused = tf;
        Debug.Log("Saving...");
        // Application.Quit();
    }
}
