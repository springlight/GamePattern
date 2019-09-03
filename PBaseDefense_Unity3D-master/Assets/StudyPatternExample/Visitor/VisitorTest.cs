using UnityEngine;
namespace Assets.StudyPatternExample.Visitor
{
   public  class VisitorTest:MonoBehaviour
    {
        private void Start()
        {
            DirectX directX = new DirectX();

            ShapeContainer container = new ShapeContainer();

            container.AddShape(new Cube(directX));
            container.AddShape(new Cylinder(directX));
            container.AddShape(new Sphere(directX));

            container.RunVisitor(new DrawVisitor());
        }
    }
}
