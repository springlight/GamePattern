using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConStateC : MyState
{
    public ConStateC(MyContext theContext) : base(theContext)
    {

    }
    public override void Handle(int value)
    {
        Debug.LogError("cccccccccccccccc");
        if(value > 30)
        {
            m_Context.SetState(new ConStateA(m_Context));
        }
    }
}
