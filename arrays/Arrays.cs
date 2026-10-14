using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca_Estruct_Datos.arrays.busqueda;

namespace Biblioteca_Estruct_Datos.arrays
{
    /// <summary>
    /// Clase para realizar las operaciones e imprimir los arreglos
    /// originales y lo que retornan.
    /// </summary>
    public class Arrays
    {
        public static void BusquedaMayor(int[] arr)
        {
            var val = Lineal.BuscarMayor(arr);
            arr.Imprimir();
            Console.WriteLine(val);
        }

        public static void BusquedaMenor(int[] arr)
        {
            var val = Lineal.BuscarMenor(arr);
            arr.Imprimir();
            Console.WriteLine(val);
        }

        public static void BusquedaBinaria(int[] arr, int valor)
        {
            var val = Binario.Buscar(arr, valor);
            arr.Imprimir();
            Console.WriteLine(val);
        }

        public static void OrdenamientoSeleccion(int[] arr)
        {
            Console.WriteLine("Arreglo original:");
            arr.Imprimir();
            Console.WriteLine("Arreglo ordenado:");
            var val = ordenamiento.Seleccion.Ordenar(arr);
            val.Imprimir();
        }

        public static void OrdenamientoBurbuja(int[] arr)
        {
            Console.WriteLine("Arreglo original:");
            arr.Imprimir();
            Console.WriteLine("Arreglo ordenado:");
            var val = ordenamiento.Burbuja.Ordenar(arr);
            val.Imprimir();
        }

        public static void OrdenamientoInsertion(int[] arr)
        {
            Console.WriteLine("Arreglo original:");
            arr.Imprimir();
            Console.WriteLine("Arreglo ordenado:");
            var val = ordenamiento.Insertion.Ordenar(arr);
            val.Imprimir();
        }
    }
}