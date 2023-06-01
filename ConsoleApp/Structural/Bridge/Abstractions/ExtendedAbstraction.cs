using ConsoleApp.Structural.Bridge.Implementations;

namespace ConsoleApp.Structural.Bridge.Abstractions
{
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                Implementation.OperationImplementation();
        }
    }
}