using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.StudyPatternExample.Memento
{
    public class Originator
    {
        string m_State;
        public void SetInfo(string state)
        {
            m_State = state;
        }
        public void ShowInfo()
        {
            Debug.LogError("记录拥有者保 状态---》" + m_State);
        }

        public Memento CreateMemento()
        {
            Memento memento = new Memento();
            memento.SetState(m_State);
            return memento;
        }

        public void SetMemento(Memento m)
        {
            m_State = m.GetState();
        }
    }
}
