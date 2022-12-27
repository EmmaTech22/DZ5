// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] numbers = { 4.3, 2.8, 1.7, 3.5, 9.1 };
double numMax = numbers[0];
double numMin = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= numMax) numMax = numbers[i]; i++;
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] <= numMin) numMin = numbers[i]; i++;
}

Console.WriteLine($"разницa между максимальным и минимальным элементов массива -> {numMax - numMin}");
