namespace ConsoleApp.Creational.AbstractFactory
{
    class AbstractFactoryExample : IExample
    {
        public void Run()
        {
            new Client().Main();
        }
    }
}
