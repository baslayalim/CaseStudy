using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public class StructuralBridgeTextMessageSender : StructuralBridgeIMessageSender
    {
        public void SendMessage(StructuralBridgeMessage message)
        {
            Console.WriteLine("TextMessageSender: Sending text message...");
        }
    }
}