using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCylinder : MyIShape
{
    public override void Draw()
    {
        m_RenderEngine.Render("画个圆柱体");
    }
}
