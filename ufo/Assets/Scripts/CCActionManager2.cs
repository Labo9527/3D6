using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCActionManager2 : Adapter
{
    public override void fly(GameObject ufo,float speed){
        CCFlyAction2 action = CCFlyAction2.GetSSAction(speed);
        this.RunAction(ufo, action, this);
    }

}
