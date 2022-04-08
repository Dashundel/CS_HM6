//2) Задать двумерный массив следующим правилом: Aₘₙ = m+n

void fillArray(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			arr[i,j] = i + j;
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

Console.WriteLine("Введи кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
fillArray(array);
printArray(array);
