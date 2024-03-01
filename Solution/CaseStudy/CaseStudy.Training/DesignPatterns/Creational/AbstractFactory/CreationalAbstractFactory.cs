using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    public class CreationalAbstractFactory
    {
        public static void AbstractFactoryCreate()
        {
            CreationalAbstractFactoryCustomOperation customOperation = new CreationalAbstractFactoryCustomOperation(new CreationalAbstractFactoryOracleDatabaseFactory());
            customOperation.RemoveById(1);
            customOperation.GetById(1);
        }
    }
}
