int[] numbers = [7, 13, 27, 32, 38, 42, 67, 86, 89, 94];

Console.WriteLine($"Массив:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

double average = numbers.Average();
Console.WriteLine($"средее значение: {average:F2}");

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > average)
    {
        count++;
    }
}

Console.WriteLine($"количество элементов выше среднего: {count}");

int[] aboveAverage = new int[count];
int index = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > average)
    {
        aboveAverage[index] = numbers[i];
        index++;
    }
}

    Console.WriteLine($"элементы выше среднего:");
for (int i = 0; i < aboveAverage.Length; i++)
{
    Console.WriteLine(aboveAverage[i]);
}