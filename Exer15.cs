using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer15
    {
        public static void Main(string[] args)
        {
            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° número:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int menor = menorNumero(num[0], num[1], num[2]);
            Console.WriteLine($"o menor número é {menor}");
        }
        public static int menorNumero(int n1, int n2, int n3)
        {
            int menor = n1;
            

       
            
            if (menor > n2)
            {
                menor = n2;
            }
            if (menor > n3)
            {
                menor = n3;
            }

            return menor;
        }
    }
}
