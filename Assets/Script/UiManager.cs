using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private Text scoreText;


    //Ajoute le score
    public void IncrementScore()
    {
        score += 100;
        scoreText.text = "Score : " + score;    
    }


}
