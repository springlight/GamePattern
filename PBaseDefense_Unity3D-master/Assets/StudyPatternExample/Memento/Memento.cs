using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Memento
{
    public class Memento
    {
        string m_State;
        public string GetState()
        {
            return m_State;
        }
        public void SetState(string state)
        {
            m_State = state;
        }
    }
}
