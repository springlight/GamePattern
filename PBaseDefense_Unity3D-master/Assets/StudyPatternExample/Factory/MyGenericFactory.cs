using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGenericFactory<T>where T:MyProduct, new()
{
    public MyGenericFactory()
    {
        Debug.LogError("产生工厂：" + typeof(T).ToString());
    }

    public MyProduct FactoryMethod()
    {
        return new T();
    }
}
