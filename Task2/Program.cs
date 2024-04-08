
 // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 // Даны два неотрицательных числа m и n.


        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m < 0 || n < 0)
        {
            Console.WriteLine("Ошибка: значения m и n должны быть неотрицательными.");
        }
        else
        {
            int result = Ackermann(m, n);
            Console.WriteLine("Результат функции Аккермана: " + result);
        }
    

     int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, n); 
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
  }
