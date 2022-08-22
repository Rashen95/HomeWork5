// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine($"Ваш массив: [{String.Join(", ", array)}]");
}

void EvenNumbers(int[] array)
{
    int Quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Quantity += 1;
        }
    }
    Console.WriteLine(Quantity);
}

Console.Clear();
Console.Write("Введите количество чисел в массиве из трехзначных чисел а я выведу данный массив и количество четных чисел в данном массиве: ");
int N  = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(N);
ShowArray(array);
EvenNumbers(array);