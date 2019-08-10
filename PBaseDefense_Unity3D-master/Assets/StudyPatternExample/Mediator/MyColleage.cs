using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyColleage
{
    protected MyMediator m_Mediator = null;//通过Mediator对外沟通

    public MyColleage(MyMediator mediator)
    {
        m_Mediator = mediator;
    }
    //Mediator通知请求
    public abstract void Request(string msg);
}
