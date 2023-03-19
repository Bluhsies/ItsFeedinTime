using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndofLevel : MonoBehaviour
{

    public GameObject defeat;
    public string levelName;

    public void Retry()
    {


        SceneManager.LoadScene(levelName);
        Time.timeScale = 1f;

    }

    public void Quit()
    {

        SceneManager.LoadScene("LevelSelect");

    }

    

}
