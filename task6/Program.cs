//6) В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

void printIndexNumber(int[,] arr, int num)
{
	bool flag = false;
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{	
			if(arr[i,j] == num) 
			{
				Console.Write("Позиция числа " + num + " : (" + i +", "+ j + ")\n");
				flag = true;
			}	
		}
	}
	if(flag == false) Console.WriteLine("Такого элемента нет");
}


Console.WriteLine("Введи кол-во строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
fillArray(array, 0, 10);

Console.WriteLine("Исходный массива: ");
printArray(array);

Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine());


printIndexNumber(array, num);

