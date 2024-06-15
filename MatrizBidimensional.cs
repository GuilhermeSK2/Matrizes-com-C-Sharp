using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesCS
{
    internal class MatrizBidimensional
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { {1,2,3}, {11,12,13} }; //Declaração de uma matriz bidimensional.
            Console.WriteLine(numeros[0, 2]); //Imprime o elemento de posição 2 da linha "0".
        }
    }
}
