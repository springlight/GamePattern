using UnityEngine;

namespace Assets.StudyPatternExample.Memento
{
    public class MementoTest:MonoBehaviour
    {
        void Start()
        {
            Originator originator = new Originator();

            originator.SetInfo("1111111111111");
            originator.ShowInfo();


            Memento memento = originator.CreateMemento();

            originator.SetInfo("22222222222");
            originator.ShowInfo();

            originator.SetMemento(memento);
            originator.ShowInfo();
        }
    }
}
