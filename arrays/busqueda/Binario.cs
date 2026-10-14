using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays.busqueda
{
    public class Binario
    {
        /// <summary>
        /// Busqueda de elemento siempre y cuando el arreglo este ordenado de menor a mayor
        /// </summary>
        /// <param name="array">Arrreglo ordenado</param>
        /// <param name="valor">Valor a buscar</param>
        /// <returns></returns>
        public static int? Buscar(int[] array, int valor)
        {
            var inicio = 0;
            var final = array.Length - 1;

            while(inicio <= final)
            {
                var medio = (inicio + final) / 2;

                if(array[medio] == valor)
                {
                    return medio;
                }

                if( array[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }

            }
            return null;
        }
    }
}