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
            Dictionary<string, int> Parientes = new Dictionary<string, int>();

            Parientes.Add("Diego Martinez", 16);
            Parientes.Add("Leonel Martinez", 38);
            Parientes.Add("Evelyn Chicas", 34);
            Parientes.Add("Cristhoper Chicas", 14);

            foreach (KeyValuePair<string, int> familia in Parientes)
            {
                Console.WriteLine("Clave: {0}, valor: {1}", Parientes.Keys, Parientes.Values);
            }
            {
                var dic = Parientes.Keys.ToList();
                dic.Sort();

                Console.WriteLine("Diccionario ordenado");
                foreach (var item in dic)
                {
                    Console.WriteLine("{0}: {1}", item, Parientes[item]);
                }
                Console.WriteLine("Elementos en el diccionario: {0}", Parientes.Count);
                Console.ReadKey();
            }
        }

    }
}
