using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays
{
    /// <summary>
    /// Clase para extender de los arrays y poder imprimirlos de una manera mas amigable
    /// </summary>
    public static class ArrayExtension
    {
        public static void Imprimir(this int[] arr)
        {
            Console.Write("Arreglo: [");
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }
    }
}