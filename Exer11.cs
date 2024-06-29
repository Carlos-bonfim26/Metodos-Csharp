using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer11
    {
        public static void Main(string[] args)
        {
            horaAtual();
        }
        public static void horaAtual()
        {
            DateTime hora = DateTime.Now;

            Console.WriteLine($"a hora atual é {hora.ToString("hh:mm")}");
        }
        
    }
}
