using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactoryCustomOperation
    {
        AbstractFactoryIDatabaseFactory _databaseFactory;
        AbstractFactoryConnection _connection;
        AbstractFactoryCommand _command;

        public AbstractFactoryCustomOperation(AbstractFactoryIDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();
        }

        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("DELETE ...");
            _connection.CloseConnection();
            Console.WriteLine("Delete : " + id + Environment.NewLine + _databaseFactory.ToString());
        }
    }
}
