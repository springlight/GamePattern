using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReceiver1
{
    public MyReceiver1() { }
    public void Action(string command)
    {
        Debug.LogError("接受者1-----开始执行命令：" + command);
    }
}

public class MyReceiver2
{
    public MyReceiver2() { }
    public void Action(int param)
    {
        Debug.LogError("接受者2-----开始执行命令：" + param.ToString());
    }
}
