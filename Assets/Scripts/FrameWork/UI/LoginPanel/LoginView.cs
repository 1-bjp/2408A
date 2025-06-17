using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : ViewBase
{
    public Button loginbtn;

    public override void Init(UIWindow uiBase)
    {
        base.Init(uiBase);
        loginbtn = uiBase.transform.Find("Button (Legacy)").GetComponent<Button>();
        loginbtn.onClick.AddListener(() =>
        {
            GameScenesManager.Instance.LoadSceneAsync("Game", "ScrollPanel");
        });
    }
}
