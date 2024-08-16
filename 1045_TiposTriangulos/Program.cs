using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1045_TiposTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] vet = Console.ReadLine().Split(' ');
            double x = float.Parse(vet[0]);
            double y = float.Parse(vet[1]);
            double z = float.Parse(vet[2]);

            double A, B, C;

            if (x > y && x > z)
            {
                A = x;
                if (y > z)
                {
                    B = y;
                    C = z;

                } else {
                    B = z;
                    C = y;
                }
            }
            else if (y > x && y > z)
            {
                A = y;
                if (x > z)
                {
                    B = x;
                    C = z;
                } else
                {
                    B = z;
                    C = x;
                }
            }
            else
            {
                A = z;
                if (x > y)
                {
                    B = x;
                    C = y;
                } else
                {
                    B = y;
                    C = x;
                }
            }

            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else {

                if ((A * A) == (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && A == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || B == C || A == C)
                {
                    Console.WriteLine("TRIANGULO ISOCELES");
                }
            }

            Console.ReadLine();
        }
    }
}
