using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Biblioteca_Estruct_Datos.arrays.busqueda
{
    public class Lineal
    {
        public static int BuscarMayor(int[] array)
        {
            int numMayor = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > numMayor)
                {
                    numMayor = array[i];
                }
            }

            return numMayor;
        }

        public static int BuscarMenor(int[] array)
        {
            int menor = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < menor)
                {
                    menor = array[i];
                }
            }

            return menor;
        }
    }
}