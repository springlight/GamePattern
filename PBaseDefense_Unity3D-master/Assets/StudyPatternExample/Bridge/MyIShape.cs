using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyIShape
{
    protected MyRenderEngine m_RenderEngine = null;
    public void SetRenderEngine(MyRenderEngine myRender)
    {
        m_RenderEngine = myRender;
    }

    public abstract void Draw();
}
