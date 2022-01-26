using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_to_Decimal_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeri_binari = new double[8];
            double numero_convertito = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Inserire un numero binario: ");
                do { } while ((double.TryParse(Console.ReadLine(), out numeri_binari[i]) && !(numeri_binari[i] == 0 || numeri_binari[i] == 1)));
            }
            for (int i = 0; i < 8; i++)
            {
                if (numeri_binari[i] == 0)
                {
                    continue;
                }
                else
                {
                    numero_convertito += Math.Pow(2, i);
                }
            }
            Console.WriteLine(numero_convertito);

            Console.ReadKey();
        }
    }
}
