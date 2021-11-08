using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {

            // suma, resta, multiplicacion y division
            int n1, n2, s, r, m;
            float di;
            string va;

            Console.WriteLine("Ingrese un numero");
            va = Console.ReadLine();
            n1 = int.Parse(va);

            Console.WriteLine("Ingrese otro numero");
            va = Console.ReadLine();
            n2 = int.Parse(va);

            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            di = n1 / n2;

            Console.WriteLine("EL RESULTADO DE LA SUMA ES: "+ s);
            Console.WriteLine("EL RESULTADO DE LA RESTA ES: "+ r);
            Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES: "+ m);
            Console.WriteLine("EL RESULTADO DE LA DIVISION ES: "+ di);

            Console.ReadKey();

        }
    }
}
