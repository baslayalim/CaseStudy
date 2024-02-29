using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactory
    {
        public static void AbstractFactoryCreate()
        {
            AbstractFactoryCustomOperation customOperation = new AbstractFactoryCustomOperation(new AbstractFactoryOracleDatabaseFactory());
            customOperation.RemoveById(1);
            customOperation.GetById(1);
        }
    }
}
