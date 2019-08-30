using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.StudyPatternExample.Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConObserver : Observer
    {
        string m_ObjectState;
        ConSubject m_Subject = null;

        public ConObserver(ConSubject subject)
        {
            m_Subject = subject;
        }

        public override void Update()
        {
            Debug.LogError("观察者1111更新");
            m_ObjectState = m_Subject.GetState();
        }
    }

    public class ConObserver2 : Observer
    {
        ConSubject m_Subject = null;
        public ConObserver2(ConSubject subject)
        {
            m_Subject = subject;
        }

        public override void Update()
        {
            Debug.LogError("观察者2222或者当前主题状态---》" + m_Subject.GetState());
        }
    }
}