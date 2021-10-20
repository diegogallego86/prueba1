using System;

namespace {programacion_1
namespace proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("probando cambio");
            int a;
            a = 2;
            int b;
            b = 3;
            int c;
            c = 5;
            Console.WriteLine("secuencias bca, aacb y bcbc de a=2, b=3 y c=5");
            //bca
            Console.WriteLine("primera secuencia:");
            Console.Write(b);
            Console.Write(c);
            Console.WriteLine(a);
            //aacb
            Console.WriteLine("segunda secuencia");
            Console.Write(a);
            Console.Write(a);
            Console.Write(c);
            Console.WriteLine(b);
            //bcbc
            Console.WriteLine("tercera secuencia");
            Console.Write(b);
            Console.Write(c);
            Console.Write(b);
            Console.Write(c);
        }
    }
}