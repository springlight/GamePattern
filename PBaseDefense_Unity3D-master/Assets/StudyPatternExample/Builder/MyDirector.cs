using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDirector
{
    private MyBuilderProduct m_Product;
    public MyDirector() { }

    public void Construct(MyBuilder theBuilder)
    {
        m_Product = new MyBuilderProduct();
        theBuilder.BuildPart1(m_Product);
        theBuilder.BuildPart2(m_Product);
    }

    public MyBuilderProduct GetResult()
    {
        return m_Product;
    }
	
}
