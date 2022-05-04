using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Soy dev");
            saludar();
        }

        static void saludar()
        {
            Console.WriteLine("Hola te saludo!!!");
            Console.WriteLine("El cuadrado es:");
            Console.WriteLine(cuadrado(10));
        }

        static int cuadrado(int a)
        {
            return a * a;
        }

    }
}
