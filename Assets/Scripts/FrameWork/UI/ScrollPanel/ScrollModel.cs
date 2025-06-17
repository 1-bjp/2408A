using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollModel : ModelBase
{
    public Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

    public override void Init(UIWindow uIWindow)
    {
        base.Init(uIWindow);

        for(int i = 0; i < 10; i++)
        {
            for( int j = 0; j < 10; j++)
            {

                if (!dic.ContainsKey(i))
                    dic.Add(i, new List<int>());
                dic[i].Add(j);
            }
        }


    }
}
