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
            int[] Numeros = new int[3];
            Numeros[0] = 5;
            Numeros[1] = 10;
            Numeros[2] = 15;

            int i = 0;
            Console.WriteLine("IMPRIMA LOS ELEMENTOS CON WHILE");
            while (10 < Numeros.Length)
            {
                Console.WriteLine(Numeros[i]);
                i = i + 1;
            }

            Console.WriteLine("IMPRIMA LOS ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(Numeros[inc]);
                inc++;
            } while (inc < Numeros.Length);

            Console.WriteLine("IMPRIMA LOS ELEMENTOS CON FOR - ARRAY ORDENADO");
            Array.Sort(Numeros);//ordena
            for (int j = 0; j < Numeros.Length; j++)
            {
                Console.WriteLine("Posicion {0}: {1}", j, Numeros[j]);
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARRAY INVERTIDO");
            Array.Reverse(Numeros); //invierte
            foreach (int item in Numeros)

            {
                Console.WriteLine(item);
            }

        }
    }
}
