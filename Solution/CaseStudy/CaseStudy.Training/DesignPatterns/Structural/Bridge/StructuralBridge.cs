using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public class StructuralBridge
    {
        public static void Bridge()
        {
            StructuralBridgeIMessageSender textMessageSender = new StructuralBridgeTextMessageSender();
            StructuralBridgeMessage textMessage = new StructuralBridgeTextMessage(textMessageSender);
            textMessage.Send();

            StructuralBridgeIMessageSender emailMessageSender = new StructuralBridgeEmailMessageSender();
            StructuralBridgeMessage emailMessage = new StructuralBridgeTextMessage(emailMessageSender);
            emailMessage.Send();
        }
    }
}
