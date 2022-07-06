using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cf, h, b, area;

            Console.WriteLine("1- Tiangulo" + "/" + "2- Pentagono" + "/" + "3- Hexagono");
            Console.WriteLine("Informe o Codigo da Figura");
            cf = Convert.ToDouble(Console.ReadLine());

            switch (cf)
            {
                case 1:
                    Console.WriteLine("Triangulo");
                    break;
                case 2:
                    Console.WriteLine("Pentagono");
                    break;
                case 3:
                    Console.WriteLine("Hexagono");
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }

            Console.WriteLine("Informe a altura da figura");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a medida da base da figura");
            b = Convert.ToDouble(Console.ReadLine());

            if (cf == 1)
            {
                area = (b * h / 2);
                Console.WriteLine("A area da figura é = " + area);
            }
            if (cf == 2)
            {
                area = (5 * ( b  * h / 2));
                Console.WriteLine("A area da figura é = " + area);
            }
            if (cf == 3)
            {
                area = (6 * (b * h / 2));
                Console.WriteLine("A area da figura é = " + area);
            }


            Console.ReadKey();
        }
    }
}
