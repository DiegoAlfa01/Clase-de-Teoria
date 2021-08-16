using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_teorica
{
    class clase_diccionario
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Familia = new Dictionary<string, int>();

            Familia.Add("Daniel Castillo", 18);
            Familia.Add("Pedro linarte", 48);
            Familia.Add("Mateo Herrera", 29);
            Familia.Add("Angel Quiros", 22);

            foreach (KeyValuePair<string, int> familia in Familia)
            {
                Console.WriteLine("Clave: {0}, valor: {1}", Familia.Keys, Familia.Values);
            }
            {
                var dic = Familia.Keys.ToList();
                dic.Sort();

                Console.WriteLine("Diccionario ordenado");
                foreach (var item in dic)
                {
                    Console.WriteLine("{0}: {1}", item, Familia[item]);
                }
                Console.WriteLine("Elementos en el diccionario: {0}", Familia.Count);
                Console.ReadKey();
            }
        }

    }
}
