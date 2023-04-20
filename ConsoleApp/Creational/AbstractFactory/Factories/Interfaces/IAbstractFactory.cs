using ConsoleApp.Creational.AbstractFactory.Products.Interfaces;

namespace ConsoleApp.Creational.AbstractFactory.Factories.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
