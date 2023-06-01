using ConsoleApp.Structural.Bridge.Abstractions;
using ConsoleApp.Structural.Bridge.Implementations;

namespace ConsoleApp.Structural.Bridge
{
    internal class BridgeExample : IExample
    {
        public void Run()
        {
            Client client = new Client();

            Abstraction abstraction;
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
