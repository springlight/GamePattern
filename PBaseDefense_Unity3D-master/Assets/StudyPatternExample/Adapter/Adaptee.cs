using UnityEngine;

namespace Assets.StudyPatternExample.Adapter
{
    public class Adaptee
    {
        public Adaptee() { }
        public void SpecificRequest()
        {
            Debug.LogError("我是敌人，我投降");
        }
    }
}
