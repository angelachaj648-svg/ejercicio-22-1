//Solicitar al usuario el tamaño de una matriz, llenarla con números y luego pedir una fila específica para mostrar únicamente los valores de esa fila

Console.WriteLine("ingrese tamaño de matriz (n * n)");
int .TryParse(Console.ReadLine(), out int n);
int[,] matriz = new int[n,n];
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.WriteLine($"valor[{i},{j}]");
		int.TryParse(Console.ReadLine(), out matriz[i, j]);
	}
}
Console.WriteLine("fila a mostrar");
int.TryParse(Console.ReadLine(),out int fila);
if (fila >= 0 && fila < n)
{
	Console.WriteLine("Fila");
	for (int j = 0; j < n; j++)
	{
		Console.WriteLine(matriz[fila, j] + " ");
	}
}
else
{
	Console.WriteLine("Fila invalida");
}

