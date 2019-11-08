using System;

namespace gof.Creational.FactoryMethod

{
    class Example:IExample
    {
        public void Main()
        {
            Console.WriteLine("\nAppFactoryMethod: Launching the Dynamic Object Creation with Type A Factory as param ...\n");
            new TheFactory(new ConcreteFactory_type_A());

            Console.WriteLine("\n");

            Console.WriteLine("\nAppFactoryMethod: Launching the Dynamic Object Creation with Type B Factory as param...\n");
            new TheFactory(new ConcreteFactory_type_B());
        }

        public Example()
        {
            Main();
        }
    }
}