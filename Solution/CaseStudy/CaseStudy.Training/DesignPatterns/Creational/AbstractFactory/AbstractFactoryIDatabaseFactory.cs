using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    interface AbstractFactoryIDatabaseFactory
    {
        AbstractFactoryConnection CreateConnection();
        AbstractFactoryCommand CreateCommand();
    }
}
