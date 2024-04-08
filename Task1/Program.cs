

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.



int m = 8;
int n = 50;

PrintNumbersInRange(m, n);


void PrintNumbersInRange(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m);
        PrintNumbersInRange(m + 1, n);
    }
}