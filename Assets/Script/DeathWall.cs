using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DeathWall : MonoBehaviour
{
    [SerializeField] private GameObject DeathPopUp; 

    private void Awake()
    {
        DeathPopUp.SetActive(false);
    }
    // Cette méthode est appelée lorsqu'un autre collider entre en collision avec la ligne de mort
    public void OnTriggerEnter2D(Collider2D collision)
    {

        // Collision qui tue le player
        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            GameOver();
        }
    }

    // Méthode appelée lorsque le jeu est terminé
    public void GameOver()
    {
        DeathPopUp.SetActive(true);
    }

    //Condition de victoire si toutes les briques sont cassées
    private void Update()
    {
        if (!FindAnyObjectByType<MainBrick>())
        { 
            GameOver();
        }
    }


}
