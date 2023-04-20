using ConsoleApp.Creational.AbstractFactory.Factories.Interfaces;
using ConsoleApp.Creational.AbstractFactory.Products;
using ConsoleApp.Creational.AbstractFactory.Products.Interfaces;

namespace ConsoleApp.Creational.AbstractFactory.Factories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
