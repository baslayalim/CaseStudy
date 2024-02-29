using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Factory
{
    class CreationalFactoryNotifyFactory
    {
        public CreationalFactoryINotify CreateNotify(CreationalFactoryType.FactoryType FactoryType)
        {
            if (FactoryType == CreationalFactoryType.FactoryType.Sms)
            {
                return new CreationalFactorySmsNotify();
            }
            else if (FactoryType == CreationalFactoryType.FactoryType.Email)
            {
                return new CreationalFactoryMailNotify();
            }
            return null;
        }
    }
}
