using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MyIShape {
    public override void Draw()
    {
        m_RenderEngine.Render("画个方块");
    }
}
