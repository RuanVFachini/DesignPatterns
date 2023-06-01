using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Creational.Singleton
{
    public class SingletonService
    {
        private SingletonService() { }

        private static SingletonService _instance;

        private static readonly object _lock = new object();

        public static SingletonService GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new()
                        {
                            Value = value
                        };
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; }
    }

}
