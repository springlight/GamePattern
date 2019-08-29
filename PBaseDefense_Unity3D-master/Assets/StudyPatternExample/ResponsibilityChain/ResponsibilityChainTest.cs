using System;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.StudyPatternExample.ResponsibilityChain
{
    public class ResponsibilityChainTest:MonoBehaviour
    {
        private void Start()
        {
            ConChainHandler3 handler3 = new ConChainHandler3(null);
            ConChainHandler2 handler2 = new ConChainHandler2(handler3);
            ConChainHandler1 handler1 = new ConChainHandler1(handler2);

            handler1.HandleRequest(10);
        }
    }
}
