//Solicitar al usuario una matriz y luego pedir un número a buscar, indicando si existe y en qué posición (fila y columna) se encuentra
Console.Write("Ingrese el número de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];


for (int i = 0; i < filas; i++)
	for (int j = 0; j < columnas; j++)
	{
		Console.Write($"Elemento [{i},{j}]: ");
		matriz[i, j] = int.Parse(Console.ReadLine());
	}


Console.WriteLine("\nMatriz:");
for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
		Console.Write($"{matriz[i, j],6}");
	Console.WriteLine();
}
Console.Write("Ingrese el número a buscar: ");
int buscar = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < filas; i++)
	for (int j = 0; j < columnas; j++)
		if (matriz[i, j] == buscar)
		{
			Console.WriteLine($"¡Número {buscar} encontrado en fila {i}, columna {j}!");
			encontrado = true;
		}

if (!encontrado)
	Console.WriteLine($"El número {buscar} NO se encuentra en la matriz.");
    