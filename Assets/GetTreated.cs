using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTreated : GAction
{
    // Start is called before the first frame update
    public override bool PrePerform()
    {
        target = inventory.FindItemWithTag("Cubicle");
        if (target == null)
            return false;
        return true;
    }
    

    // Update is called once per frame
    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("Treated", 1);
        inventory.RemoveItem(target);

    return true;
    }
}
