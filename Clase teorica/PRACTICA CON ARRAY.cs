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


            string[] Alumnos = new string[10];
            string[] genero = new string[10];
            int[] edad = new int[10];
            int femenino = 0;
            int masculino = 0;

            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.WriteLine("Porfavor ingrese el nombre del alumno");
                Console.Write("Nombre {0}: ", i);
                Alumnos[i] = Console.ReadLine();
                Console.WriteLine("Porfavor ingrese el genero del estudiante  f/m");
                genero[i] = Console.ReadLine();
                Console.WriteLine("Porfavor ingrese la edad del estudiante");
                edad[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Alumnos[i], genero[i], edad[i]);
                {
                    Console.WriteLine("Datos de los alumnos: ");

                    {
                        Console.WriteLine("Nombre: {0}  l  Genero: {1} l Edad: {2}", Alumnos[i], genero[i], edad[i]);
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


