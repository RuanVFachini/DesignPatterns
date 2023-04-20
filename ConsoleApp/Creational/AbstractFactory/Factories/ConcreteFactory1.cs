using ConsoleApp.Creational.AbstractFactory.Factories.Interfaces;
using ConsoleApp.Creational.AbstractFactory.Products;
using ConsoleApp.Creational.AbstractFactory.Products.Interfaces;

namespace ConsoleApp.Creational.AbstractFactory.Factories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
