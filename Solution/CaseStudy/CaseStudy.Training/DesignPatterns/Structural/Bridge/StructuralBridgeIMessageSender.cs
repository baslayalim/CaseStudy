using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Bridge
{
    public interface StructuralBridgeIMessageSender
    {
        void SendMessage(StructuralBridgeMessage message);
    }
}
