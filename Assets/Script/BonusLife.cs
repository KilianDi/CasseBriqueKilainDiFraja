using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusLife : BonusMain
{

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        DeathWall.instance.AddLife();
        base.OnCollisionEnter2D(collision);
    }
}
