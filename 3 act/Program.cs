//Solicitar al usuario filas y columnas, llenar la matriz con números enteros y calcular la suma total de todos los elementos mostrando el resultado

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
int suma = 0;
for (int i = 0; i < filas; i++)
	for (int j = 0; j < columnas; j++)
		suma += matriz[i, j];
