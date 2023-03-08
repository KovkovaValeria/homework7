// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] numbers = new int[3, 4];
void FillArray(int[,] array) //Заполнение массива рандомными числами
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(0, 11);
		}
	}
}


void PrintArray(int[,] array) // Вывод массива в терминал
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}
FillArray(numbers);
PrintArray(numbers);

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

