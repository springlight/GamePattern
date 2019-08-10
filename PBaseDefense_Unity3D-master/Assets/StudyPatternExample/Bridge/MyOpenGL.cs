using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOpenGL : MyRenderEngine
{
    public override void Render(string ObjName)
    {
        GLRender(ObjName);
    }

    public void GLRender(string ObjName)
    {
        Debug.LogError("OpenGL..." + ObjName);
    }
}
