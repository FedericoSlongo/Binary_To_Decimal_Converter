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
            Console.Write("Inert how many number you wanna convert: ");
            int array_lenght;
            do { } while (int.TryParse(Console.ReadLine(), out array_lenght));
            double[] numeri_binari = new double[array_lenght];
            double numero_convertito = 0;
            for (int i = 0; i < array_lenght; i++)
            {
                Console.Write($"Insert the {i} binary number: ");
                do { } while ((double.TryParse(Console.ReadLine(), out numeri_binari[i]) && !(numeri_binari[i] == 0 || numeri_binari[i] == 1)));
            }
            for (int i = 0; i < array_lenght; i++)
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
            Console.WriteLine($"The converted number is {numero_convertito}");

            Console.ReadKey();
        }
    }
}
