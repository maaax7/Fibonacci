using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double anterior = 1;
            double proximo = 1;
            double auxiliar = 0;
            string saida = anterior + ", " + proximo + ", ";
            for (int i = 1; i <= 100; i++)
            {
                auxiliar = proximo;
                proximo += anterior;
                anterior = auxiliar;
                saida += proximo + ", ";
                
            }

            Console.WriteLine(saida);
        }
    }
}
