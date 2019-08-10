using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 状态拥有者
/// </summary>
public  class MyContext
{
    /// <summary>
    /// 代表当前的状态
    /// </summary>
    MyState m_State = null;
    /// <summary>
    /// 外界通过调用request，让context呈现当前状态的行为
    /// </summary>
    /// <param name="value"></param>
    public void Request(int value)
    {
        m_State.Handle(value);
    }

    public void SetState(MyState theState)
    {
        Debug.LogError("Context.SetState:" + theState);
        m_State = theState;
    }
}
