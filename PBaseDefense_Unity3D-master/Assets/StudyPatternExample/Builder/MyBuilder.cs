using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyBuilder
{
    public abstract void BuildPart1(MyBuilderProduct theProduct);
    public abstract void BuildPart2(MyBuilderProduct theProduct);
}

public class MyConBuilderA : MyBuilder
{
    public override void BuildPart1(MyBuilderProduct theProduct)
    {
        theProduct.AddPart("AAAAA11111111111111");
    }

    public override void BuildPart2(MyBuilderProduct theProduct)
    {
        theProduct.AddPart("AAAA2222222222222222222");
    }
}

public class MyConBuilderB : MyBuilder
{
    public override void BuildPart1(MyBuilderProduct theProduct)
    {
        theProduct.AddPart("BBBB11111111111111");
    }

    public override void BuildPart2(MyBuilderProduct theProduct)
    {
        theProduct.AddPart("BBBBB2222222222222222222");
    }
}