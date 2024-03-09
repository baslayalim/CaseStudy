using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public class StructuralBridgeEmailMessageSender : StructuralBridgeIMessageSender
    {
        public void SendMessage(StructuralBridgeMessage message)
        {
            Console.WriteLine("EmailMessageSender: Sending email message...");
        }
    }
}
