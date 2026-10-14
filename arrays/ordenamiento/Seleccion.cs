using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays.ordenamiento
{
    public class Seleccion
    {
        public static int[] Ordenar(int[] arr)
        {
            for(int i = 0; i < arr.Length -1; i++)
            {
                int min = i;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    int aux = arr[i];
                    arr[i] = arr[min];
                    arr[min] = aux;
                }
            }

            return arr;
        }
    }
}