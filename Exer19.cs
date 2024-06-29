using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Exer19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um texto");
            string txt = Console.ReadLine();

            string txtInvertido = InverterString(txt);

            Console.WriteLine(txtInvertido);
        }
        public static string InverterString(string txt)
        {
            string novoTxt = "";
            char[] chars = txt.ToCharArray();
            Array.Reverse(chars);

            foreach (char c in chars)
            {
                novoTxt += Convert.ToString(c);
            }
            return novoTxt;
           
        }
       
    }
}
