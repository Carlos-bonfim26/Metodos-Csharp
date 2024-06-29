using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o valor do primeiro Cateto:");
            float ct1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do segundo Cateto:");
            float ct2 = float.Parse(Console.ReadLine());

            double hipotenusa = CalcularHipotenusa(ct1, ct2);

            Console.WriteLine($"a hipotenusa desse triângulo é {hipotenusa}");
        }
        public static double CalcularHipotenusa(float cateto1, float cateto2)
        {
            double somaCatetos = Math.Pow(cateto1, 2) +  Math.Pow(cateto2, 2);

            double hipotenusa = Math.Sqrt(somaCatetos);

            return hipotenusa;
        }
    }
}
