using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantForagable : ToolHit
{
    public override void Hit()
    {
        Destroy(gameObject);
    }
}
