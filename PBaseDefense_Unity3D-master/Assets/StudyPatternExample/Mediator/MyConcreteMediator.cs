using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyConcreteMediator : MyMediator
{
    ConColleageOne m1 = null;
    ConColleageTwo m2 = null;
    public void SetM1(ConColleageOne m1)
    {
        this.m1 = m1;
    }
    public void SetM2(ConColleageTwo m2)
    {
        this.m2 = m2;
    }
    //收到来自Colleague的通知请求
    public override void SendMsg(MyColleage theColleague, string msg)
    {
        //收到m1通知m2
        if(m1 == theColleague)
        {
            m2.Request(msg);
        }
        if (m2 == theColleague)
            m1.Request(msg);
    }
}
