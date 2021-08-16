using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_teorica
{
    class Explicación_de_clase
    {
        static void Main(string[] args)
        {
            loops();

            Console.ReadLine();
        }

        public static void loops()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (10 < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1;
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);

            Console.WriteLine("IMPRIMA ELEMENTOS CON FOR - Array ordenado");
            Array.Sort(numbers);//ordena
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0}: {1}", j, numbers[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - Array invertido");
            Array.Reverse(numbers); //invierte
            foreach (int item in numbers)

            {
                Console.WriteLine(item);
            }

        }
    }
}
