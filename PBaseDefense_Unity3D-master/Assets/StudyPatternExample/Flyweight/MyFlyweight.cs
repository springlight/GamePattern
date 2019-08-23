using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyFlyweight
{
    //代表共享的信息
    protected string m_Content;
    public MyFlyweight() { }

    public MyFlyweight(string Content)
    {
        m_Content = Content;
    }

    public string GetContent()
    {
        return m_Content;
    }

    public abstract void Operator();
}

public class ConFlyweight : MyFlyweight
{
    public ConFlyweight(string Content) : base(Content)
    {

    }

    public override void Operator()
    {
        Debug.LogError("共享组件---->"+m_Content);
    }
}

public class UnSharedConFlyWeight
{
    MyFlyweight m_Flyweight = null;//共享的组件
    string m_UnsharedContent;//不共享的组件

    public UnSharedConFlyWeight(string Content)
    {
        m_UnsharedContent = Content;
    }
    public void SetFlyweight(MyFlyweight myFlyweight)
    {
        m_Flyweight = myFlyweight;
    }

    public void Operator()
    {
        string msg = string.Format("分共享组件---->{0}", m_UnsharedContent);
        if(m_Flyweight != null)
        {
            msg += "包含了：" + m_Flyweight.GetContent();
        }

        Debug.LogError(msg);
    }
}
