using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Roles
{
    public override void Info()
    {
        base.Info();
        DEFBuff();
    }

    private void DEFBuff()
    {
        Debug.Log($"Defense skin has been increased by 45%! {_def} >>> {(_def * (1 + .45))}");
    }

}
