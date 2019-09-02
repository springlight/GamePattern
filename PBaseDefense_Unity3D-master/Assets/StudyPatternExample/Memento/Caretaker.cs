using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Memento
{
    public class Caretaker
    {

        Dictionary<string, Memento> m_Mementos = new Dictionary<string, Memento>();
        public void AddMemento(string version,Memento memento)
        {
            if (!m_Mementos.ContainsKey(version))
                m_Mementos.Add(version, memento);
            else
                m_Mementos[version] = memento;
        }


        public Memento GetMemento(string version)
        {
            if (!m_Mementos.ContainsKey(version)) return null;
            return m_Mementos[version];
        }
    }
}
