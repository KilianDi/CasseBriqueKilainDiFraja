using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    
    //on veut reload la scene en appuyant sur le bouton une fois mort
    public void ReloadScene()
    {
        SceneManager.LoadScene("Jeu");

    }

    //Pour quitter l'application
    public void Exit()
    {
        Application.Quit();
    }

  
}
