using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaMetodosdeBusqueda
{
    internal class Search
    {
        public static int BusquedaLineal(int[] arreglo, int objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo)
                    return i;
            }
            return -1; 
        }
        public static int BusquedaBinaria(int[] arreglo, int objetivo)
        {
            int izquierda = 0, derecha = arreglo.Length - 1;
            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                if (arreglo[medio] == objetivo)
                    return medio; 
                if (arreglo[medio] < objetivo)
                    izquierda = medio + 1; 
                else
                    derecha = medio - 1; 
            }
            return -1; 
        }
    }
}

