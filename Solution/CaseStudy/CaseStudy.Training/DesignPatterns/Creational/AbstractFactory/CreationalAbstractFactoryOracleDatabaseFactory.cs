using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class CreationalAbstractFactoryOracleDatabaseFactory : CreationalAbstractFactoryIDatabaseFactory
    {
        public CreationalAbstractFactoryCommand CreateCommand()
        {
            return new CreationalAbstractFactoryOracleCommand();
        }
        public CreationalAbstractFactoryConnection CreateConnection()
        {
            return new CreationalAbstractFactoryOracleConnection();
        }
    }
}
