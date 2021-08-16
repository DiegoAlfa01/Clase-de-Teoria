using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_teorica
{
    class Practica_con_array
    {


        static void Main()
        {


            string[] estudiantes = new string[10];
            string[] genero = new string[10];
            int[] edad = new int[10];
            int femenino = 0;
            int masculino = 0;

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                Console.Write("Nombre {0}: ", i);
                estudiantes[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el genero del estudiante  f/m");
                genero[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante");
                edad[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(estudiantes[i], genero[i], edad[i]);
                {
                    Console.WriteLine("Datos de los estudiantes: ");

                    {
                        Console.WriteLine("Nombre: {0}  l  Genero: {1} l Edad: {2}", estudiantes[i], genero[i], edad[i]);
                    }
                }



                if (genero[i] == "f")
                {
                    femenino += 1;
                }
                if (genero[i] == "m")
                {
                    masculino += 1;
                }
            }




            Console.ReadKey();
        }


    }
}


