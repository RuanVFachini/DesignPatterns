using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Creational.FactoryMethod
{
    public class FactoryMethodExample : IExample
    {
        public void Run()
        {
            new Client().Main();
        }
    }
}
