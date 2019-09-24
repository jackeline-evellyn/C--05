using System;

namespace _7_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);


            p.Nome = "Tz";

            Console.WriteLine(p.Nome);
        }
    }
}