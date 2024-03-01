using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class CreationalAbstractFactoryMySQLConnection : CreationalAbstractFactoryConnection
    {
        public override bool OpenConnection()
        {
            return true;
        }
        public override bool CloseConnection()
        {
            return true;
        }
    }
}
