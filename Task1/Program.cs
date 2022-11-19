/*
    Запросите от пользователя размерности двумерного массива.
    Напишите метод для заполнения массива случайными числами.
    Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво).
    Округлите значения, генерируемые Random до двух знаков после запятой.
*/

Console.Clear();

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((new Random().NextDouble() * 10 - new Random().NextDouble() * 20),2);
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,10}", array[i,j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arrayRandom = new double[m,n];
Console.WriteLine();

FillArray(arrayRandom);
PrintArray(arrayRandom);

Console.ReadKey();