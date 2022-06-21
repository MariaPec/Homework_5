// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int[] MyArray = RandomArray(10, 100, 999);
PrintArray(MyArray);

int count = 0;

for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] == MyArray[i] / 2 + MyArray[i] / 2)
    {
      count = count + 1;  
    }

}
Console.WriteLine($" ");
Console.WriteLine($"Количество четных чисел в массиве - {count}");
