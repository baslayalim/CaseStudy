﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactoryMySQLCommand : AbstractFactoryCommand
    {
        public override void ExecuteCommand(string query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
            Console.WriteLine("Delete Çalıştırıldı");
        }
        public override void GetCommand(string query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
            Console.WriteLine("Select Çalıştırıldı");
        }
    }
}
