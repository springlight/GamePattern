using UnityEngine;

namespace Assets.StudyPatternExample.Visitor
{
    public abstract class IShape
    {
        protected RenderEngine m_RenderEngine = null;
        protected Vector3 m_Position = Vector3.zero;
        protected Vector3 m_Scale = Vector3.zero;


        public void SetRenderEngine(RenderEngine renderEngine)
        {
            m_RenderEngine = renderEngine;
        }

        public Vector3 GetPosition()
        {
            return m_Position;
        }

        public Vector3 GetScale()
        {
            return m_Scale;
        }

        public abstract void Draw();
        public abstract float GetVolume();
        public abstract int GetVectorCount();
        public abstract void RunVisitor(IShapeVisitor visitor);

    }

    public class Sphere : IShape
    {
        public Sphere(RenderEngine renderEngine)
        {
            base.SetRenderEngine(renderEngine);
        }
        public override void Draw()
        {
            m_RenderEngine.Render("画个球");
        }

        public override int GetVectorCount()
        {
            return 3;
        }

        public override float GetVolume()
        {
            return 0;
        }

        public override void RunVisitor(IShapeVisitor visitor)
        {
            visitor.VisitShpere(this);
        }
    }

    public class Cube : IShape
    {
        public Cube(RenderEngine renderEngine)
        {
            base.SetRenderEngine(renderEngine);
        }
        public override void Draw()
        {
            m_RenderEngine.Render("画个方块");
        }

        public override int GetVectorCount()
        {
            return 3;
        }

        public override float GetVolume()
        {
            return 0;
        }

        public override void RunVisitor(IShapeVisitor visitor)
        {
            visitor.VisitCube(this);
        }
    }

    public class Cylinder : IShape
    {
        public Cylinder(RenderEngine renderEngine)
        {
            base.SetRenderEngine(renderEngine);
        }
        public override void Draw()
        {
            m_RenderEngine.Render("画个圆柱体");
        }

        public override int GetVectorCount()
        {
            return 3;
        }

        public override float GetVolume()
        {
            return 0;
        }

        public override void RunVisitor(IShapeVisitor visitor)
        {
            visitor.VisitCylinder(this);
        }
    }
}
