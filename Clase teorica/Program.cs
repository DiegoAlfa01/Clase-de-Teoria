using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_teorica
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            EmployeeList.Add("Luis Gavidia", "Programador");
            EmployeeList.Add("Juan Torres", "Gerente");
            EmployeeList.Add("Lucas Sandoval", "Ingeniero");

            Dictionary<string, int> Students = new Dictionary<string, int>();

            Students.Add("Luis Gavidia", 16);
            Students.Add("Juan Torres", 38);
            Students.Add("Lucas Sandoval", 42);

           
            foreach (KeyValuePair<string, string> employee in EmployeeList)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

          
            var dic = EmployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("Diccionario ordenado");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, EmployeeList[item]);
            }

         
            Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList.Count);

            Console.ReadKey();
        }
    }
}
