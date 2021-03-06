//5) В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void fillArray(int[,] arr, int startEl, int endEl)
{
	Random rnd = new Random();
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			arr[i,j] = rnd.Next(startEl, endEl + 1);
	}

}

void printArray(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			Console.Write(String.Format("{0, 4} ", arr[i,j]) );
		Console.WriteLine();	
	}	
}

void changeArray(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i = i + 2)
	{
		for(int j = 0; j < arr.GetLength(1); j = j + 2)
			arr[i,j] = arr[i,j] * arr[i,j];	
	}	
}

Console.WriteLine("Введи кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
fillArray(array, 0, 10);
Console.WriteLine("Исходный массива: ");
printArray(array);
changeArray(array);
Console.WriteLine("Измененный массива: ");
printArray(array);
