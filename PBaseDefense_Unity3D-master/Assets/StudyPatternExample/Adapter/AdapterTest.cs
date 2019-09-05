using UnityEngine;

namespace Assets.StudyPatternExample.Adapter
{
    public class AdapterTest:MonoBehaviour
    {
        private void Start()
        {
            Target target = new Adapter();
            target.Request();
        }

    }
}
