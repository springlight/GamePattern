using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Visitor
{
    public abstract class IShapeVisitor
    {
        public virtual void VisitShpere(Sphere sphere) { }
     

        public virtual void VisitCube(Cube cube) { }

        public virtual void VisitCylinder(Cylinder cylinder) { }
    }
}
