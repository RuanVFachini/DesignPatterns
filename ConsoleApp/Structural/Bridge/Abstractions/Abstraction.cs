using ConsoleApp.Structural.Bridge.Implementations;

namespace ConsoleApp.Structural.Bridge.Abstractions
{
    public class Abstraction
    {
        protected readonly IImplementation Implementation;

        public Abstraction(IImplementation implementation)
        {
            Implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                Implementation.OperationImplementation();
        }
    }
}
