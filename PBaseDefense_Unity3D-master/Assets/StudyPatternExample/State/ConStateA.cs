using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConStateA : MyState
{
    public ConStateA(MyContext theContext) : base(theContext)
    {

    }
    public override void Handle(int value)
    {
        Debug.LogError("AAAAAAAAAAAAAAAAAAAAAA");
        if(value > 10)
        {
            //设置m_Context当前的状态
            m_Context.SetState(new ConStateB(m_Context));
        }
    }
}
