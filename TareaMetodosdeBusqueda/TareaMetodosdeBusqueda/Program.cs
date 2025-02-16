class program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];

        Console.WriteLine("Ingrese los elementos del arreglo:");
        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese el número a buscar: ");
        int objetivo = int.Parse(Console.ReadLine());

        // Búsqueda Lineal
        int resultadoLineal = Busqueda.BusquedaLineal(numeros, objetivo);
        Console.WriteLine(resultadoLineal != -1 ? $"Búsqueda Lineal: Número encontrado en la posición {resultadoLineal}" : "Búsqueda Lineal: Número no encontrado.");

        
        Otro.OrdenarArreglo(numeros);
        Console.WriteLine("Arreglo ordenado para búsqueda binaria: " + string.Join(", ", numeros));

        // Búsqueda Binaria
        int resultadoBinario = Busqueda.BusquedaBinaria(numeros, objetivo);
        Console.WriteLine(resultadoBinario != -1 ? $"Búsqueda Binaria: Número encontrado en la posición {resultadoBinario}" : "Búsqueda Binaria: Número no encontrado.");
    }
}