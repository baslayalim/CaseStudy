using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Factory
{
    public class CreationalFactoryType
    {
        public enum FactoryType
        {
            Email = 1, 
            Sms = 2, 
            Mobil = 3,
            Web = 4
        }
    }
}
