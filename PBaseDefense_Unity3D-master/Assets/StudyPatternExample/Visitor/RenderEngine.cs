using UnityEngine;

namespace Assets.StudyPatternExample.Visitor
{
    public abstract class RenderEngine
    {
        public abstract void Render(string ObjName);
        public abstract void Text(string text);
    }

    public class DirectX : RenderEngine
    {
        public override void Render(string ObjName)
        {
            DXRender(ObjName);
        }

        public override void Text(string text)
        {
           DXRender(text);
        }

        public void DXRender(string objName)
        {
            Debug.LogError("DXXXXXXX :" + objName);
        }
    }

    public class OpenGL : RenderEngine
    {
        public override void Render(string ObjName)
        {
            GLRender(ObjName);
        }

        public override void Text(string text)
        {
            GLRender(text);
        }

        public void GLRender(string objName)
        {
            Debug.LogError("GLLLLLLLL :" + objName);
        }
    }
}
