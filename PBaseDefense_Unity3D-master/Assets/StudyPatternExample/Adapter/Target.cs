using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Adapter
{
    public abstract class Target
    {
        public abstract void Request();
    }

    public class Adapter : Target
    {
        private Adaptee m_Adaptee = new Adaptee();
        public override void Request()
        {
            m_Adaptee.SpecificRequest();
        }
    }
}
