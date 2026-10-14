using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays.ordenamiento
{
    public class Insertion
    {
        public static int[] Ordenar(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int actual = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > actual)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = actual;
            }

            return arr;
        }
    }
}