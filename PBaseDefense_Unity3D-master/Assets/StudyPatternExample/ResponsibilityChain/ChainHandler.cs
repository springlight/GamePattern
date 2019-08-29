using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.StudyPatternExample.ResponsibilityChain
{
    public abstract class ChainHandler
    {
        protected ChainHandler m_NextHandler = null;
        public ChainHandler(ChainHandler chainHandler)
        {
            m_NextHandler = chainHandler;
        }

        public  virtual void HandleRequest(int cost)
        {
            if (m_NextHandler != null)
                m_NextHandler.HandleRequest(cost);
        }
    }

    public class ConChainHandler1 : ChainHandler
    {
        private int m_CostCheck = 10;
        public ConChainHandler1(ChainHandler nextHandler):base(nextHandler)
        {

        }
        public override void HandleRequest(int cost)
        {
            if(cost <= m_CostCheck)
            {
                Debug.Log("ConChainHandler 1111 处理请求");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }

    public class ConChainHandler2 : ChainHandler
    {
        private int m_CostCheck = 20;
        public ConChainHandler2(ChainHandler nextHandler) : base(nextHandler)
        {

        }
        public override void HandleRequest(int cost)
        {
            if (cost <= m_CostCheck)
            {
                Debug.Log("ConChainHandler 22222 处理请求");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }


    public class ConChainHandler3 : ChainHandler
    {
        public ConChainHandler3(ChainHandler nextHandler) : base(nextHandler)
        {

        }
        public override void HandleRequest(int cost)
        {
            Debug.Log("ConChainHandler 33333 处理请求");
            
        }
    }
}
