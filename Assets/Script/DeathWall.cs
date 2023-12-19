using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DeathWall : MonoBehaviour
{
    [SerializeField] private GameObject DeathPopUp;
    [SerializeField] int life = 3;
    [SerializeField] private TextMeshProUGUI lifesText;
    public static DeathWall instance;

    

    private void Awake()
    {
        if (instance == null)
            instance = this;
        DeathPopUp.SetActive(false);
    }
    // Cette m�thode est appel�e lorsqu'un autre collider entre en collision avec la ligne de mort
    public void OnTriggerEnter2D(Collider2D collision)
    {

        // Collision qui enl�ve des vies
        if (collision.TryGetComponent(out BallMovement ball))
        {
            TakeLifes();
            if (life == 0)
            {
                GameOver();
            }
            else
            {
                ball.ResetBall();
            }
            
        }
    }

    // M�thode appel�e lorsque le jeu est termin�
    public void GameOver()
    {
        DeathPopUp.SetActive(true);
        Time.timeScale = 0f;
    }

    //Condition de victoire si toutes les briques sont cass�es
    private void Update()
    {
        if (!FindAnyObjectByType<MainBrick>())
        {
            GameOver();
        }
    }

    public void TakeLifes()
    {
        life--;
        lifesText.SetText("Life points : " + life.ToString());
    }

    public void AddLife ()
    {
        life++;
        lifesText.SetText("Life points : " + life.ToString());
    }

}
