// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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


int[] MyArray = RandomArray(10, -5, 50);
PrintArray(MyArray);

int max = MyArray[0];
int min = MyArray[0];

for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i] >= max)
    {
    max = MyArray[i];
    }
    if (MyArray[i] <= min)
    {
    min = MyArray[i]; 
    }

}

int result = max - min;
Console.WriteLine($" ");
Console.WriteLine($"Разница между максимальным и минимальным значением равна {result}");