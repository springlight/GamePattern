using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConColleageTwo : MyColleage
{
    public ConColleageTwo(MyMediator theMediator) : base(theMediator) { }

    public void Action()
    {
        m_Mediator.SendMsg(this, "22222222222222222222222发送通知");
    }
    public override void Request(string msg)
    {
        Debug.LogError("222222 Request--->" + msg);
    }
}
