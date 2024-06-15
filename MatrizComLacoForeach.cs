using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesCS
{
    internal class MatrizComLacoForeach
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 4, 2 }, { 3, 6, 8 } }; //Declaração da matriz.

            foreach (int i in numeros) //Parâmetro do laço foreach, definindo que a variável "i" vai percorrer a matriz.
            {
                Console.WriteLine(i); //Exibe os valores encontrados por "i" dentro da matriz.
            }
        }
    }
}
