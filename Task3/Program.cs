// Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

Console.Clear();

void FillArray(double[,] array, int[] size)
{
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,8}", array[i,j]);
        }
        Console.WriteLine();
    }
}
double[] GetAverageInCol(double[,] array)
{
    double[] average = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumCol = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumCol = sumCol + array[j,i];
        }
        average[i] = sumCol / array.GetLength(0);
        Console.Write("{0,8:f1}", average[i]);
    }
    return average;
}

Console.Write("Введите размерность двумерного массива. Через пробел - сначала количество строк, затем столбцов: ");
int[] sizeOfArray = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

double[,] arrayRandom = new double[sizeOfArray[0], sizeOfArray[1]];

Console.WriteLine();
FillArray(arrayRandom, sizeOfArray);

Console.WriteLine("Входной массив случайных чисел:");
Console.WriteLine();
PrintArray(arrayRandom);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбца:");
Console.WriteLine();
    
double[] resAverage = GetAverageInCol(arrayRandom);

Console.ReadKey();