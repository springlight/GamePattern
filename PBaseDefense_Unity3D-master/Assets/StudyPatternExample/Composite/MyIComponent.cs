using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyIComponent
{
    protected string m_Value;
    public abstract void Operation();
    public virtual void Add(MyIComponent theComponent)
    {
        Debug.LogError("子类没有实现Add功能");
    }

    public virtual void Remove(MyIComponent theComponent)
    {
        Debug.LogError("子类没有实现Remove功能");
    }

    public virtual MyIComponent GetChild(int idx)
    {
        Debug.LogError("子类没有实现GetChild功能");
        return null;
    }

}


public class MyComposite : MyIComponent
{
    List<MyIComponent> m_Childs = new List<MyIComponent>();
    public MyComposite(string value)
    {
        m_Value = value;
    }

    public override void Operation()
    {
        Debug.LogError("MyComposite [" + m_Value + "]");
        foreach(MyIComponent myIComponent in m_Childs)
        {
            myIComponent.Operation();
        }

    }

    public override void Add(MyIComponent theComponent)
    {
        m_Childs.Add(theComponent);
    }

    public override void Remove(MyIComponent theComponent)
    {
        m_Childs.Remove(theComponent);
    }

    public override MyIComponent GetChild(int idx)
    {
        return m_Childs[idx];
    }
}

public class MyLeaf : MyIComponent
{
    public MyLeaf(string value)
    {
        m_Value = value;
    }

    public override void Operation()
    {
        Debug.LogError("叶子节点-" + m_Value + "执行Operation");
    }
}