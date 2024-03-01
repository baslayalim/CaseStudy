using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class CreationalAbstractFactoryCustomOperation
    {
        CreationalAbstractFactoryIDatabaseFactory _databaseFactory;
        CreationalAbstractFactoryConnection _connection;
        CreationalAbstractFactoryCommand _command;

        public CreationalAbstractFactoryCustomOperation(CreationalAbstractFactoryIDatabaseFactory databaseFactory)
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
        
        public void GetById(int id)
        {
            _connection.OpenConnection();
            _command.GetCommand("Select ...");
            _connection.CloseConnection();
            Console.WriteLine("Select : " + id + Environment.NewLine + _databaseFactory.ToString());
        }
    }
}
