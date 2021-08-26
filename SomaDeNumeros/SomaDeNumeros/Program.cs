using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, result = 0;
            string nome = "";

            Console.Write("(|☼|-|☼|) vou somar uns negocio pra vc, mas me fala seu nome antes: ");
            nome = Console.ReadLine();

            Console.Write("Fala o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Fala o segundo numerossa: ");
            num2 = Int32.Parse(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("(|☼|-|☼|) "+nome+ ", o resultado é isso ai: " + result);



            Console.WriteLine("");
            






            Console.ReadKey();
















        }
    }
}
