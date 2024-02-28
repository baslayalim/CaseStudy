using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.DesignPatterns.Creational.Singleton
{ 
    public class CreationalSingletonDatabase
    {
        private static object lockObject = new Object();
        private static CreationalSingletonDatabase? database; 
        private CreationalSingletonDatabase() { }

        public static CreationalSingletonDatabase GetInstance()
        {
            if (database == null)
            {
                lock (lockObject)
                {
                    if (database == null)
                    {
                        database = new CreationalSingletonDatabase();
                    }
                }
            }
            return database;
        }
    }
}
