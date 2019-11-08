using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using gof.Creational;
using gof.Behavioral;

namespace gof
{
    class Program
    {
        static void Main(string[] args)
        {
            string selector = "default";
            while (selector != "exit")
            {
                Console.WriteLine("\nExamples of Design Patterns!\n\nType a name for run an example : ");
                selector = Console.ReadLine();
                selector = selector.ToLower();
                switch (selector)
                {
                    case "observer":
                            new Behavioral.Observer.Example();
                        break;
                    case "factorymethod":
                             new Creational.FactoryMethod.Example(); 
                        break;
                }
            }
            Console.WriteLine("\n\nPress any key to close me ...");
            Console.ReadKey();
        }
    }

    
}


// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

