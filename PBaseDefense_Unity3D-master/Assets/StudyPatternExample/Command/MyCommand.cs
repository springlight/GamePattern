using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyCommand  {
    public abstract void Execute();
}

public class ConCommand1 : MyCommand
{
    MyReceiver1 m_Receiver = null;
    string m_Command = "";

    public ConCommand1(MyReceiver1 receiver1,string command)
    {
        m_Receiver = receiver1;
        m_Command = command;
    }

    public override void Execute()
    {
        m_Receiver.Action(m_Command);
    }
}

public class ConCommand2 : MyCommand
{
    MyReceiver2 m_Receiver = null;
    int m_Command = 0;

    public ConCommand2(MyReceiver2 receiver2, int command)
    {
        m_Receiver = receiver2;
        m_Command = command;
    }

    public override void Execute()
    {
        m_Receiver.Action(m_Command);
    }
}
