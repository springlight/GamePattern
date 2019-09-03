using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Visitor
{
    public class ShapeContainer
    {
        List<IShape> m_Shapes = new List<IShape>();
        public ShapeContainer() { }
        public void AddShape(IShape shape)
        {
            m_Shapes.Add(shape);
        }


        public void DrawAllShapes()
        {
            foreach(IShape shape in m_Shapes)
            {
                shape.Draw();
            }
        }

        public void RunVisitor(IShapeVisitor visitor)
        {
            foreach(IShape shape in m_Shapes)
            {
                shape.RunVisitor(visitor);
            }
        }
    }
}
