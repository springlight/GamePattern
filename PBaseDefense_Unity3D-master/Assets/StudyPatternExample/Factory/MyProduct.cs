using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyProduct
{
}

public class ConProductA : MyProduct
{
    public ConProductA()
    {
        Debug.LogError("产生对象AAAAAAAAAAA");
    }
}

public class ConProductB : MyProduct
{
    public ConProductB()
    {
        Debug.LogError("产生对象BBBBBBBBBBBBBBBB");
    }
}
