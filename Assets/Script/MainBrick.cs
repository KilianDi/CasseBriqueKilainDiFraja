using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class MainBrick : MonoBehaviour
{
    public UiManager ui;
    [SerializeField] protected int pv;
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
            LoosePV();
        }


    }

    protected virtual void LoosePV()
    {
        if (pv <= 0)
        {
            Destroy(gameObject);

        }
    }
}
