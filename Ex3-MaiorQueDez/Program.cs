using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_MaiorQueDez
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o Primeiro Número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("\nEsse número é maior do qque 10");
            }

                    else
                    {
                        Console.WriteLine("\nEsse número não é maior do que 10");
                    }
            Console.ReadKey();
        }
    }
}
