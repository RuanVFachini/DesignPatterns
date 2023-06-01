using ConsoleApp.Structural.Bridge.Abstractions;

namespace ConsoleApp.Structural.Bridge
{
    public class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}