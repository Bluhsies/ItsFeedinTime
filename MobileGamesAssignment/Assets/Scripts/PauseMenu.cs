using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject pauseMenuUI;



    // If the game is paused, it will reset the timer so that gameplay is no longer paused and hide the canvas which the script is applied to. This can also be used with a resume button, which when clicked using the mouse will resume the game.
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    // If the game is currently running and not paused, the time is set to zero for the timeScale and will pause gameplay, allowing the user to return to the main menu or quit the game. Pressing the escape key again will resume the game,
    // via the Resume() function.
    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    // Through the use of a button, the player can select to go back to the main menu of the game, by loading the "Menu" scene. This will then set the timeScale to 1f, allowing the menu to run without issue.
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
        isPaused = false;
    }

    // Through the use of a button, the player can select the quit button and quit the game altogether.
    public void QuitGame()
    {
        Debug.Log("Quitting game!");
        Application.Quit();
    }

}
