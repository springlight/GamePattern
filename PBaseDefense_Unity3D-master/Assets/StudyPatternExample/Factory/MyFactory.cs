using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyFactory
{
    public abstract MyProduct FactoryMethod();

}

//一个类一个工厂
public class ConProductAFactory : MyFactory{
    public override MyProduct FactoryMethod()
    {
        return new ConProductA();
    }
}

public class ConProductBFactory : MyFactory
{
    public override MyProduct FactoryMethod()
    {
       return new ConProductB();
    }
}
