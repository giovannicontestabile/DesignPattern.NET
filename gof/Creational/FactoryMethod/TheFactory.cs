using System;

namespace gof.Creational.FactoryMethod
{
    class TheFactory
    {
        public  TheFactory(AbstractFactory factory)
        {
            // ...
            Console.WriteLine("\n{ClassWrapper} my param is the factory :" + factory.ToString() + "\nI don't creating nothing. I'm just a container." +
                "\nBut I'm still working.\nNow it's time to do Somenthing :\n" + factory.DoSomething());
            // ...
        }
    }
}
