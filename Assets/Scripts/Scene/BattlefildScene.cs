using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlefildScene : BaseScene
{
    public override IEnumerator LoadingRoutine()
    {
        Manager.Game.SetData();
        yield return null;
    }
}
