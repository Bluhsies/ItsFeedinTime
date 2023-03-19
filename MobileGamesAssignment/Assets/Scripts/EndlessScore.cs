using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EndlessScore : MonoBehaviour
{

    public TMP_Text scoreText;
    [SerializeField]
    private int scoreValue;
    public string PlayerScore;
    

    
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

        
    }

    
    public void UpdateScoreText()
    {

        Debug.Log("Update");
        scoreText.text = PlayerScore + " " + scoreValue;
    }

    

}
