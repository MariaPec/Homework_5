// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray(int length, int min, int max)
{
    int[] array;
    array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] PArray)
{
    for (int j = 0; j < PArray.Length; j++)
    {
        Console.Write($"{PArray[j]} ");
    }
}


int[] MyArray = RandomArray(10, 0, 10);
PrintArray(MyArray);

int count = 0;

for (int i = 0; i < MyArray.Length; i = i + 2)
{
    count = MyArray[i] + count;
}
Console.WriteLine(" ");
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {count}");