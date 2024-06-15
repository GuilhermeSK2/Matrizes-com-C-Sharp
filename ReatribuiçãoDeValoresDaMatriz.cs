using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesCS
{
    internal class ReatribuiçãoDeValoresDaMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } }; //Declaração da matriz.
            numbers[0, 0] = 5; //Reatribuição do valor de acordo com sua linha e coluna.
            Console.WriteLine(numbers[0, 0]); //Impressão do valor, devendo ser exibido o novo valor atribuido.
        }
    }
}
