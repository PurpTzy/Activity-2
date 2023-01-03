using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : Roles
{
    public override void Info()
    {
        base.Info();
        Heal();
    }

    private void Heal()
    {
        Debug.Log("Healed everyone in the vicinity within 2 meters.");
    }
}