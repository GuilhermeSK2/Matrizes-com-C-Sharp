using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesCS
{
    internal class MatrizComLacoFor
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 4, 2 }, { 3, 6, 8 } }; //Declaração da matriz.

            for (int i = 0; i < numeros.GetLength(0); i++) //Utilizando GetLength() para especificar a linha que será percorrida.
            {
                for (int j = 0; j < numeros.GetLength(1); j++) //Utilizando GetLength() para especificar a linha que será percorrida.
                {
                    Console.WriteLine(numeros[i, j]); //Imprime o valor correspondente a vez em que o laço está sendo executado.
                }
            }
        }
    }
}
