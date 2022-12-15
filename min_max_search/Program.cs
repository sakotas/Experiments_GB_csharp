// See https://aka.ms/new-console-template for more information
Console.WriteLine("Начало программы");

int[] list = { 5, 1, 3, 4, 2 };

int i = 0;
int maxValueIndex = 0;
int minValueIndex = 0;
int size = list.Length;

Console.Write("Размер массива: ");
Console.WriteLine(size);

while (i < size)
{
    if (list[i] > list[maxValueIndex])
    {
        maxValueIndex = i;
    }
    else if (list[i] < list[minValueIndex])
    {
        minValueIndex = i;
    }
    i++;
}

Console.Write("Индекс максимального элемента в массиве: ");
Console.WriteLine(maxValueIndex);
Console.Write("Индекс минимального элемента в массиве: ");
Console.WriteLine(minValueIndex);
