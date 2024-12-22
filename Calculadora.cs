using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AtributosMetodosEstaticos
{
    internal class Calculadora
    {
        // Atributo numerico
        public static int numero = 10;

        // Metodo para somar dois valores
        public static void Soma(int n1, int n2)
        {
            Console.WriteLine($"A soma dos valores e: {n1 + n2}");
        }
    }
}
