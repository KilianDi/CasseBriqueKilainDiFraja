using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class BrickBonus : MainBrick
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

