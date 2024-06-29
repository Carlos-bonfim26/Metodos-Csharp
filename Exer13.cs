using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a altura do retângulo:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a base do retângulo:");
            float largura = float.Parse(Console.ReadLine());

            float area = areaRetangulo(altura, largura);

            Console.WriteLine($"a área do retângulo é {area}");
        }
        public static float areaRetangulo(float altura, float largura)
        {
            float area = altura * largura;
            return area;
        }
        
    }
}
