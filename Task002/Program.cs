// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void sumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");
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
sumNumbers(array);