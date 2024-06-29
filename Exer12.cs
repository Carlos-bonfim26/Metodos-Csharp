using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            quadrado(numero);
        }
        public static void quadrado(int numero)
        {
            Console.WriteLine($"{numero}² = {numero * numero}");
        }
    }
}
