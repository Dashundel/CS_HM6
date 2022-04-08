//1) Показать двумерный массив размером m×n заполненный вещественными числами
void fillArray(double[,] arr)
{
	var rnd = new Random();
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			arr[i,j] = rnd.NextDouble();
	}

}

void printArray(double[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
			Console.Write(String.Format("{0, 4}", arr[i,j]) );
		Console.WriteLine();	
	}	
}	

Console.WriteLine("Введи кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];
fillArray(array);
printArray(array);


