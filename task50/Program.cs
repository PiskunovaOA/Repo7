// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


Random rnd = new Random();
int[,] arr = new int[10, 10];
FillArray();


void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Заполняем элемент массива по данному индексу рандомным занчением
            arr[i, j] = rnd.Next(0, 1000);
        }
    }
}

Console.WriteLine($"Введите номер строки от 0 до {arr.GetLength(0)}: ");
int rowTargetIndex = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Введите номер столбца от 0 до {arr.GetLength(1)}: ");
int columnTargetIndex = Int32.Parse(Console.ReadLine());

// Найти элемент в массиве по заданному индексу
void SearchValueInArray(int[,] arr,int rowTargetIndex,int columnTargetIndex)
{
    // 200 100
    if (rowTargetIndex >= arr.GetLength(0) || columnTargetIndex >= arr.GetLength(1))
    {
        Console.WriteLine("Вы превысели гранницы массива");
    }
    else
    {
        int arrayValue = arr[rowTargetIndex, columnTargetIndex];
        Console.WriteLine($"Значение массива по индексу строка: {rowTargetIndex} столбец: {columnTargetIndex} = {arrayValue}");
    }
}

SearchValueInArray(arr,rowTargetIndex,columnTargetIndex);
Console.ReadLine();