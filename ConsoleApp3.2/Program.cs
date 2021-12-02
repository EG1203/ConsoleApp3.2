using System;
Random r = new Random();

int n = r.Next(10, 9999);

Console.WriteLine("Натуральное число n: " + n);

Console.WriteLine("Предпоследняя цифра числа n: " + n % 100 / 10);

Console.ReadKey();