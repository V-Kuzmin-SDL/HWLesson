

// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] array = new int[] { 1, 2, 3, 4, 5 };
PrintArrayReverse(array, array.Length - 1);
    

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    else
    {
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}

