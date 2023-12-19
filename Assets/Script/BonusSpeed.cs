using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : BonusMain
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement.instance.AddForce();
        base.OnCollisionEnter2D(collision);
    }
}
