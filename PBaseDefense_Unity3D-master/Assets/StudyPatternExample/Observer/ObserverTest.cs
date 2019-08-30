using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.StudyPatternExample.Observer
{
    public class ObserverTest:MonoBehaviour
    {
        private void Start()
        {
            ConSubject conSubject = new ConSubject();
            ConObserver observer1 = new ConObserver(conSubject);
            ConObserver2 observer2 = new ConObserver2(conSubject);

            conSubject.Attach(observer1);
            conSubject.Attach(observer2);

            conSubject.SetSate("主题辩护啦");
            
        }
    }
}
