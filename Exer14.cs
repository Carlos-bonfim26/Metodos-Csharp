using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o raio do círculo:");
            float raio = float.Parse(Console.ReadLine());

            double perimetro = perimetroCirculo(raio);

            Console.WriteLine($"o raio do círculo é {perimetro}");
        }
        public static double perimetroCirculo(float raio)
        {
         
           
            double perimetro = 2f * Math.PI  * raio;
            return perimetro;
                
        }
    }
}
