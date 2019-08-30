using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.StudyPatternExample.Observer
{
    public abstract class Subject
    {
        List<Observer> m_Observers = new List<Observer>();
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            m_Observers.Add(observer);
        }
        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            m_Observers.Remove(observer);
        }

        //通知所有观察者
        public void Notify()
        {
            foreach(Observer observer in m_Observers)
            {
                observer.Update();
            }
        }
    }

    public class ConSubject : Subject
    {
        string m_SubjectState;
        public void SetSate(string state)
        {
            m_SubjectState = state;
            Notify();
        }

        public string GetState()
        {
            return m_SubjectState;
        }
    }
}
