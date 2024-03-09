using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public abstract class StructuralBridgeMessage
    {
        protected StructuralBridgeIMessageSender messageSender;

        public StructuralBridgeMessage(StructuralBridgeIMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public abstract void Send();
    }
}
