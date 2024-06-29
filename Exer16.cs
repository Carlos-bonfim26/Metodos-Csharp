using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número pra ver se ele é primo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            string isPrimo = ehprimo(numero) ? $"{numero} é primo" : $"{numero} não é primo";

            Console.WriteLine(isPrimo);
        }
        public static bool ehprimo(int primo)
        {
            if (primo <= 1)
            {
                return false;
            }
            if(primo == 2)
            {
                return true;
            }
            if (primo % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < Math.Sqrt(primo); i++)
            {
               if(primo % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
