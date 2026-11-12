int[] numbers = new int[10];

Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 101);
}

Console.WriteLine($"Массив рандомных чисел:");
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
