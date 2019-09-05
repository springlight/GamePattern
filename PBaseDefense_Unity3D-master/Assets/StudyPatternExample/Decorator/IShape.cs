using Assets.StudyPatternExample.Visitor;
using UnityEngine;

namespace Assets.StudyPatternExample.Decorator
{
    public abstract class IShape
    {
        protected RenderEngine m_RenderEngine;

        public void SetRenderEngine(RenderEngine renderEngine)
        {
            m_RenderEngine = renderEngine;
        }
        public abstract void Draw();
        public abstract string GetPolygon();
    }

    public class Sphere : IShape
    {
        public override void Draw()
        {
            m_RenderEngine.Render("球球");
        }

        public override string GetPolygon()
        {
            return "球球多边形";
        }
    }

    public abstract class IShapeDecorator : IShape
    {
        IShape m_Component;//被装饰者
        public IShapeDecorator(IShape component)
        {
            m_Component = component;
        }

        public override void Draw()
        {
            Debug.LogError("m_Compoonet ---" + m_Component.GetHashCode());
            m_Component.Draw();
        }

        public override string GetPolygon()
        {
            return m_Component.GetPolygon();
        }

        public IShape GetComponent()
        {
            return m_Component;
        }
    }


    public class BorderDecorator : IShapeDecorator
    {
        Border m_Border = new Border();
        

        public BorderDecorator(IShape theComponent) : base(theComponent) { }

        public virtual void SetRenderEngine(RenderEngine renderEngine)
        {
            base.SetRenderEngine(renderEngine);
            m_Border.SetRenderEngine(renderEngine);
        }

        public override void Draw()
        {
            //被装饰者的功能
            base.Draw();
            //外框功能
            m_Border.DrawOnShape(GetComponent());
        }
    }
}
