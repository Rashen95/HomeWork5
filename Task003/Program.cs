// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int N, int start, int end)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine($"Ваш массив: [{String.Join(", ", array)}]");
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Clear();
Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон возможных чисел в массиве");
Console.Write("От: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int end = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(N, start, end);
ShowArray(array);
int max = Max(array);
int min = Min(array);
Console.WriteLine($"Максимальное число массива: {max}");
Console.WriteLine($"Минимальное число массива: {min}");
Console.WriteLine($"Разница между минимальным и максимальным значением массива равно: {Math.Abs(max-min)}");