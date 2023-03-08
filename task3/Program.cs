// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
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
FillArray(array);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
	double sum = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		sum = Math.Round(((sum + array[i, j]) / 3), 1);

	}
	Console.Write($"{sum} ");
}

