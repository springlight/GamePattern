using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Visitor
{
    public class DrawVisitor : IShapeVisitor
    {
        public override void VisitCube(Cube cube)
        {
           cube.Draw();
        }

        public override void VisitCylinder(Cylinder cylinder)
        {
            cylinder.Draw();
        }

        public override void VisitShpere(Sphere sphere)
        {
           sphere.Draw();
        }
    }
}
