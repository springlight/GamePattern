using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Visitor
{
    public class VectorCountVisitor:IShapeVisitor
    {
        public int count = 0;


        public override void VisitCube(Cube cube)
        {
            count += cube.GetVectorCount();
        }

        public override void VisitCylinder(Cylinder cylinder)
        {
           count += cylinder.GetVectorCount();
        }

        public override void VisitShpere(Sphere sphere)
        {
            count += sphere.GetVectorCount();
        }
    }
}
