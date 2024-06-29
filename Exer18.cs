using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura em celcius");
            float c = float.Parse(Console.ReadLine());

            float f = convertFahrenheit(c);

            Console.WriteLine($"{c}°c é igual a {f}°f");
        }
        public static float convertFahrenheit(float celcius)
        {
            float fahrenheit = celcius * 9 / 5 + 32;

            return fahrenheit;
        }
    }
}
