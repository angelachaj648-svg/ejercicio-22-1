//Solicitar al usuario una matriz de números enteros y determinar cuál es el número mayor que se encuentra dentro de toda la matriz
Console.Write("Ingrese el número de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];

// Llenar matriz
for (int i = 0; i < filas; i++)
	for (int j = 0; j < columnas; j++)
	{
		Console.Write($"Elemento [{i},{j}]: ");
		matriz[i, j] = int.Parse(Console.ReadLine());
	}

// Encontrar el mayor
int mayor = matriz[0, 0];
int filaMax = 0, colMax = 0;

for (int i = 0; i < filas; i++)
	for (int j = 0; j < columnas; j++)
		if (matriz[i, j] > mayor)
		{
			mayor = matriz[i, j];
			filaMax = i;
			colMax = j;
		}

// Mostrar matriz
Console.WriteLine("\nMatriz:");
for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
		Console.Write($"{matriz[i, j],6}");
	Console.WriteLine();
}

Console.WriteLine($"\nEl número mayor es: {mayor}");
Console.WriteLine($"Se encuentra en: fila {filaMax}, columna {colMax}");
    