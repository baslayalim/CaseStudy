using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Decorator
{
    interface StructuralDecoratorIDataSource
    {
        string GetFileName();
        void WriteData(object data);
        void ReadData();
    }
}
