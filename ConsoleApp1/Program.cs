//Solicitar al usuario la cantidad de filas y columnas de una matriz, llenarla con números enteros y mostrarla en pantalla en forma de tabla
Console.WriteLine("Ingrese la cantidad de filas ");
int.TryParse(Console.ReadLine(), out int filas);
Console.WriteLine("Ingrese el numero de columnas");
int.TryParse(Console.ReadLine(), out int columnas);

int[,] matris = new int[filas,columnas];
for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
	{
		Console.WriteLine($"Valor○[{i},{j}]: ");
		int.TryParse(Console.ReadLine(), out matris[i, j]);
	}
}
Console.WriteLine("Matris ");
for (int i = 0; i < filas; i++)
{
	for (int j = 0;j < columnas; j++)
	{
		Console.Write(matris[i, j] + "t");
	}
	Console.WriteLine();
}
