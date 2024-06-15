using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesCS
{
    internal class MatrizTridimensional
    {
        public static void Main(string[] args)
        {
            //Declaração de uma matriz tridimensional
            int[,,] numeros = {  
            { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, //Linha 1 da matriz (Posição "0" com 3 grupos de elementos com 3 elementos em cada começando em posição 0 a ordem dos elementos dentro de seu grupo)
            { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } }, //Linha 2 da matriz. (Posição "1" com 3 grupos de elementos com 3 elementos em cada começando em posição 0 a ordem dos elementos dentro de seu grupo)
            { { 19, 20, 21 }, { 22, 23, 24 }, { 25, 26, 27 } } //Linha 3 da matriz. (Posição "2" com 3 grupos de elementos com 3 elementos em cada começando em posição 0 a ordem dos elementos dentro de seu grupo)
        };
            Console.WriteLine(numeros[2, 2, 2]); // Acessa o elemento da matriz tridimensional, o primerio valor é referente a qual linha, o segundo é a qual coluna, e o terceiro a qual posição do item.
        }
    }
}
