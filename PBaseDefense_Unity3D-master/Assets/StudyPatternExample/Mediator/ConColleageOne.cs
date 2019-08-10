using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConColleageOne : MyColleage
{
    public ConColleageOne(MyMediator theMediator) : base(theMediator) { }


    public void Action()
    {
        //执行后通知其他Colleague
        m_Mediator.SendMsg(this, "1111111发通知");
    }
    //Mediator通知请求
    public override void Request(string msg)
    {
        Debug.LogError("11111 request:--" + msg);
    }
}
