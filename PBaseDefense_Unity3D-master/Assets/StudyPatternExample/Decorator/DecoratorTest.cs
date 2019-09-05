using Assets.StudyPatternExample.Visitor;
using UnityEngine;

namespace Assets.StudyPatternExample.Decorator
{
    public class DecoratorTest:MonoBehaviour
    {
        OpenGL openGL = new OpenGL();

        Sphere theSphere = new Sphere();

        private void Start()
        {
            theSphere.SetRenderEngine(openGL);

            BorderDecorator border = new BorderDecorator(theSphere);
            Debug.LogError("初始球---" + theSphere.GetHashCode());
            Debug.LogError("border ----" + border.GetHashCode());
            border.SetRenderEngine(openGL);
            border.Draw();
        }


    }
}
