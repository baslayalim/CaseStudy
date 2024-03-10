using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Decorator
{
    abstract class StructuralDecoratorDataSourceDecorator : StructuralDecoratorIDataSource
    {
        protected StructuralDecoratorIDataSource dataSource;

        public StructuralDecoratorDataSourceDecorator(StructuralDecoratorIDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public abstract string GetFileName();

        public abstract void ReadData();
        
        public abstract void WriteData(object data);
    }
}
