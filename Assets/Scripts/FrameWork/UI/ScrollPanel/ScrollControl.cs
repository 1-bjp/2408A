using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class ScrollControl : ControlBase
{

    public override void Init(UIWindow uIWindow)
    {
        base.Init(uIWindow);

        (uIWindow.view as ScrollView).Refresh((uIWindow.model as ScrollModel).dic);
        
    }
}
