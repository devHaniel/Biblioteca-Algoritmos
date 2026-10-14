using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays.ordenamiento
{
    public class Burbuja
    {
        public static int[] Ordenar(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }
            }
            
            return arr;
        }
    }
}