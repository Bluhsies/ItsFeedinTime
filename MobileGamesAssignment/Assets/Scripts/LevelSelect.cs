using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
   

    public void LevelOne()
    {

        SceneManager.LoadScene("Candyland");

    }


    public void LevelTwo()
    {

        SceneManager.LoadScene("UndertheSea");

    }

    public void LevelThree()
    {

        SceneManager.LoadScene("DinnerTable");


    }

    public void Tootorial()
    {

        SceneManager.LoadScene("Tutorial");

    }

    public void Endless()
    {

        SceneManager.LoadScene("DiarrhoeaDungeon");

    }

    public void Back()
    {

        SceneManager.LoadScene("MainMenu");

    }

}
