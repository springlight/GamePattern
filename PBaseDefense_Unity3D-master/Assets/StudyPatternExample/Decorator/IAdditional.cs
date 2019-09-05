using Assets.StudyPatternExample.Visitor;
using UnityEngine;

namespace Assets.StudyPatternExample.Decorator
{
    public abstract class IAdditional
    {
        protected RenderEngine m_RennderEngine;
        public void SetRenderEngine(RenderEngine renderEngine)
        {
            m_RennderEngine = renderEngine;
        }

        public abstract void DrawOnShape(IShape shape);
    }

    public class Border : IAdditional
    {
        public override void DrawOnShape(IShape shape)
        {
            Debug.LogError("Border 里面的 shape 是--" + shape.GetHashCode());
            m_RennderEngine.Render("画边框 在" + shape.GetPolygon()+"上");
        }
    }
}
