namespace ConsoleApp.Creational.AbstractFactory.Products.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
