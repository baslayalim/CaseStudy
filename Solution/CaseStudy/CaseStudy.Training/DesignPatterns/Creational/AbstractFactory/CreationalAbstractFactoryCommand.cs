using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    public abstract class CreationalAbstractFactoryCommand
    {
        public abstract void ExecuteCommand(string query);
        public abstract void GetCommand(string query);
         
    }
}
