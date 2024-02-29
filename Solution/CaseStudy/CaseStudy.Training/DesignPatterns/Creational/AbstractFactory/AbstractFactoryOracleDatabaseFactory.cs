using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactoryOracleDatabaseFactory : AbstractFactoryIDatabaseFactory
    {
        public AbstractFactoryCommand CreateCommand()
        {
            return new AbstractFactoryOracleCommand();
        }
        public AbstractFactoryConnection CreateConnection()
        {
            return new AbstractFactoryOracleConnection();
        }
    }
}
