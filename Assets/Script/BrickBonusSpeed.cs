using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBonusSpeed : MainBrick
{
    public GameObject bonus;

    protected override void LoosePV()
    {
        base.LoosePV();
        if (pv <= 0)
        {
            Instantiate(bonus, transform.position, Quaternion.identity);
        }
    }
}
