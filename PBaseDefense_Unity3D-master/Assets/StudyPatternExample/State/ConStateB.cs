using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConStateB : MyState
{
    public ConStateB(MyContext theContext) : base(theContext)
    {

    }
    public override void Handle(int value)
    {
        Debug.LogError("BBBBBBBBBBBBBBBBBBB");
        if(value > 20)
        {
            m_Context.SetState(new ConStateC(m_Context));
        }
    }
}
