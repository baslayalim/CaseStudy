using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Decorator
{
    public class StructuralDecorator
    {
        public static void Decorator()
        {
            StructuralDecoratorIDataSource dataSource = new StructuralDecoratorFileDataSource("HsData.sql");
            StructuralDecoratorIDataSource compressedDataSource = new StructuralDecoratorComporessionDecorator(dataSource);
            compressedDataSource.ReadData();
            compressedDataSource.WriteData(new object());

            //StructuralDecoratorIDataSource _dataSource = new StructuralDecoratorFileDataSource("HsData.sql");
            //_dataSource.ReadData();
            //_dataSource.WriteData(" Hata : 424234");
        }
    }
}
