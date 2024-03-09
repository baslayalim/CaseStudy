using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public class StructuralBridgeEmailMessage : StructuralBridgeMessage
    {
        public StructuralBridgeEmailMessage(StructuralBridgeIMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            messageSender.SendMessage(this);
        }
    }
}
