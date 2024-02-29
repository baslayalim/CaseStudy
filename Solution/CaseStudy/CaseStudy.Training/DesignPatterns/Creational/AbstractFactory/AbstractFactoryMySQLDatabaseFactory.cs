using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    // MySQL için ilişkili nesneler üretildi.
    class AbstractFactoryMySQLDatabaseFactory : AbstractFactoryIDatabaseFactory
    {
        public AbstractFactoryCommand CreateCommand()
        {
            return new AbstractFactoryMySQLCommand();
        }
        
        public AbstractFactoryConnection CreateConnection()
        {
            return new AbstractFactoryMySQLConnection();
        }
    }
}
