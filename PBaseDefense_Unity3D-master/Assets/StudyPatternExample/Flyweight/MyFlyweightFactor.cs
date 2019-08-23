using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFlyweightFactor
{
    Dictionary<string, MyFlyweight> m_Flyweights = new Dictionary<string, MyFlyweight>();

    //获取共享的组件
    public MyFlyweight GetFlyweight(string key,string Content)
    {
        if(m_Flyweights.ContainsKey(key))
        {
            return m_Flyweights[key];
        }

        ConFlyweight conFlyweight = new ConFlyweight(Content);
        m_Flyweights[key] = conFlyweight;
        Debug.LogError("创建 key：" + key + "Content :" + Content);
        return conFlyweight;
    }


    //获取非共享组件
    public UnSharedConFlyWeight GetUnsharedFlyweight(string Content)
    {
        return new UnSharedConFlyWeight(Content);
    }

    //获取组件（包含共享部分的Flyweight
    public UnSharedConFlyWeight GetUnsharedFlyweight(string key,string sharedContent,string unsharedContent)
    {
        //现获取共享的部分
        MyFlyweight sharedFlyweight = GetFlyweight(key, sharedContent);
        //产生组件
        UnSharedConFlyWeight theFlyweight = new UnSharedConFlyWeight(unsharedContent);
        theFlyweight.SetFlyweight(sharedFlyweight);
        return theFlyweight;
    }
}
