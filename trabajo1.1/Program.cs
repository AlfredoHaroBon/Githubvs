using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo1._1
{
    class HelloWorld
    {
        public string Greeting;
        public HelloWorld()
        {
            Greeting = "Mundo ";

        }

        static void Main(string[] args)
        {

            HelloWorld x = new HelloWorld();
            Console.WriteLine($"Hola {x.Greeting}");
            Console.ReadLine();
        }
    }
}
