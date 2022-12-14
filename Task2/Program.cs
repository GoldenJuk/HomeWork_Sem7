/* 
    Программу, которая принимает от пользователя позицию (M, N) двумерного массива
    и возвращает значение элемента, стоящего в этой позиции. Если такой позиции в массиве нет, 
    то сообщиает об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
    Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.
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
double GetElemetValue(double[,] array, int mElement, int nElement)
{
    double result = 0;
    if (mElement > 4 || nElement > 5) Console.WriteLine("В массиве отсутствует элемент в такой позиции");
    else
    {
        result = array[mElement - 1,nElement - 1]; 
    }
    return result;
}

double[,] arrayRandom = new double[4,5];

FillArray(arrayRandom);

Console.Write("Введите номер строки массива искомого элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца массива искомого элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

double res = GetElemetValue(arrayRandom, m, n);

Console.WriteLine();
Console.WriteLine($"Искомый элемент: {res}");
Console.WriteLine();
Console.WriteLine("Mассив:");
Console.WriteLine();

PrintArray(arrayRandom);

Console.ReadKey();