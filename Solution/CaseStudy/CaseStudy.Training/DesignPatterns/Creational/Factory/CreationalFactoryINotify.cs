using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Factory
{
    interface CreationalFactoryINotify
    {
        void SendNotification(CreationalFactoryUser user);
    }
}
