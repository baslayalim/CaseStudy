using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    // MySQL için ilişkili nesneler üretildi.
    class CreationalAbstractFactoryMySQLDatabaseFactory : CreationalAbstractFactoryIDatabaseFactory
    {
        public CreationalAbstractFactoryCommand CreateCommand()
        {
            return new CreationalAbstractFactoryMySQLCommand();
        }
        
        public CreationalAbstractFactoryConnection CreateConnection()
        {
            return new CreationalAbstractFactoryMySQLConnection();
        }
    }
}
