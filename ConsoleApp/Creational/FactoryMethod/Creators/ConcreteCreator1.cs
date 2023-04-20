using ConsoleApp.Creational.FactoryMethod.Products.Interfaces;
using ConsoleApp.Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Creational.FactoryMethod.Creators.Abstracts;

namespace ConsoleApp.Creational.FactoryMethod.Creators
{
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
