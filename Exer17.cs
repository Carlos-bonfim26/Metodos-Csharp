using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer17
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}° número aleatório gerado: {numeroAleatorio()}");
            }
            Console.WriteLine();
        }
        public static int numeroAleatorio()
        {
            Random random = new Random();

            int num = random.Next(1, 101);

            return num;
        }
    }
}
