using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Structural.Decorator
{
    class StructuralDecoratorFileDataSource : StructuralDecoratorIDataSource
    {
        private string _fileName;

        public StructuralDecoratorFileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void ReadData()
        {
            Console.WriteLine($"{_fileName} Okundu.");
        }

        public void WriteData(object data)
        {
            Console.WriteLine($"Data Yazıldı {data} -  {_fileName}.");
        }
    }
}
