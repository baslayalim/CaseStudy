using CaseStudy.Training.DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Factory
{
    public class CreationalFactory
    {
        public static void CreateFactory()
        {
            CreationalFactoryNotifyFactory notifyFactory = new CreationalFactoryNotifyFactory();
            CreationalFactoryINotify notify = notifyFactory.CreateNotify(CreationalFactoryType.FactoryType.Email);
            notify.SendNotification( new CreationalFactoryUser { Name = "Training", Mail = "training@training.com" });
        }
    } 
}
