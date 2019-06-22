using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEsMultiploDeOtro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Ingrese el primer número (A): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número (B): ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a % b == 0)
            {
                Console.WriteLine("El número A: {0} es múltiplo del número B: {1}", a, b);
            }
            else
            {
                Console.WriteLine("El número A: {0} NO es múltiplo del número B: {1}", a, b);
            }
            Console.ReadKey();
        }
    }
}
