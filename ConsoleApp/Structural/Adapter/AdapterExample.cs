using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Structural.Adapter
{
    internal class AdapterExample : IExample
    {
        public void Run()
        {
            XmlResponse adaptee = new ();
            ITarget target = new XmlResponseAdapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
