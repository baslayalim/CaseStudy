using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class CreationalAbstractFactoryOracleCommand : CreationalAbstractFactoryCommand
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine("Delete Çalıştırıldı");

        }
        public override void GetCommand(string query)
        {
            Console.WriteLine("Select Çalıştırıldı");
        }
    }
}
