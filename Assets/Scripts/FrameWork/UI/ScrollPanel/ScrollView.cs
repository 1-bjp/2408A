using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView : ViewBase
{
    Transform contentLeft;
    Transform contentRight;
    GameObject itemLeft;
    GameObject itemRight;

    public override void Init(UIWindow uIWindow)
    {
        base.Init(uIWindow);
        contentLeft = uIWindow.transform.Find("Left/Viewport/LeftContent");
        contentRight = uIWindow.transform.Find("Right/Viewport/RightContent");
        itemLeft = uIWindow.transform.Find("Left/Viewport/LeftContent/Item").gameObject;
        itemRight = uIWindow.transform.Find("Right/Viewport/RightContent/Item").gameObject;



    }
    internal void Refresh(Dictionary<int,List<int>> dic)
    {
        itemLeft.SetActive(false);
        itemRight.SetActive(false);


        for(int i = 0; i < (dic.Count>contentLeft.childCount?dic.Count:contentLeft.childCount); i++)
        {

            if (contentLeft.childCount > i)
            {
                contentLeft.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                GameObject.Instantiate(itemLeft, contentLeft.transform).SetActive(false);
            }

            if (i > dic.Count)
            {
                contentLeft.GetChild(i).gameObject.SetActive(false);
            }
        }


        
    }

}
