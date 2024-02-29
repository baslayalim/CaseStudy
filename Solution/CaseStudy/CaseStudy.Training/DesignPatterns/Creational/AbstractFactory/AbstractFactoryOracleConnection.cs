using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactoryOracleConnection : AbstractFactoryConnection
    {
        public override bool OpenConnection()
        {
            // Oracle veri tabanı bağlantısının açılması için
            // Gerekli operasyonel işlemler...
            return true;
        }
        public override bool CloseConnection()
        {
            // Oracle veri tabanı bağlantısının kapatılması için
            // Gerekli operasyonel işlemler...
            return true;
        }
    }
}
