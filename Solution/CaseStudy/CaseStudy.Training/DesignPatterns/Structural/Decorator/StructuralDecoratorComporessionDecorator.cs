using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Decorator
{
    class StructuralDecoratorComporessionDecorator : StructuralDecoratorDataSourceDecorator
    {
        public StructuralDecoratorComporessionDecorator(StructuralDecoratorIDataSource dataSource) : base(dataSource) { }

        public override string GetFileName()
        {
            return base.dataSource.GetFileName();
        }

        public override void ReadData()
        {
            base.dataSource.ReadData();
        }

        public override void WriteData(object data)
        {
            Console.WriteLine("Text Kuculdu");
            Console.WriteLine($"Data Yazıldı {base.dataSource.GetFileName()}.");
        }
    }
}
