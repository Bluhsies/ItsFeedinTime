using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

   
    public TMP_Text scoreText;
    [SerializeField]
    private int scoreValue;
    [SerializeField]
    private int winScore;
    
    public string LoadScene;
    
    public string PlayerScore;
    
    public string RoundScore;

    
    void Start()
    {
        scoreValue = 0;
        UpdateScoreText();


    }

   

   
    public void UpdateScoreValue(int scoreUpdate)
    {

        Debug.Log("Scored");

        scoreValue += scoreUpdate;

        UpdateScoreText();

        if (scoreValue >= winScore)
        {
            SceneManager.LoadScene(LoadScene);
        }
    }

    
    public void UpdateScoreText()
    {

        Debug.Log("Update");
        scoreText.text = PlayerScore + " " + scoreValue + RoundScore;
    }

}
