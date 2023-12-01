using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainBrick : MonoBehaviour
{
    public UiManager ui;
    [SerializeField] private int pv;
    public DeathWall deathWall;

    private void Start()
    {
        ui = GameObject.FindWithTag("Ui").GetComponent<UiManager>();
    }

    //Destruction de la brique
    private void OnCollisionEnter2D(Collision2D _collision)
    {
        if (_collision.gameObject.tag == "Ball")
        {
            pv -= 1;
            ui.IncrementScore();
            if (pv <= 0)
            {
                Destroy(gameObject);
            }
           
        }
    }
}
