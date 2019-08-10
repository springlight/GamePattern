using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyState
{
    /// <summary>
    /// 让state在后续的操作中，可以获取Context对象的信息，每个状态都有当前状态的拥有者
    /// </summary>
    protected MyContext m_Context = null;
    public MyState(MyContext theContext)
    {
        m_Context = theContext;
    }
    public abstract void Handle(int value);
}
