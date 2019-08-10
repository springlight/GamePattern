using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDirectX : MyRenderEngine
{
    public override void Render(string ObjName)
    {
        DXRender(ObjName);
    }
    public void DXRender(string ObjName)
    {
        Debug.LogError("DXRender......" + ObjName);
    }
}
