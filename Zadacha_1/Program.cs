﻿int a, b = 0, c= 0;
        
            Console.Write("Введите 5-и значное положительное число: ");
            a = Int32.Parse(Console.ReadLine());
            c = a;
            while (a > 0) 
            {
                b = b * 10;
                b = b + a % 10;
                a = a /10;
            }
            if (c == b)
            {
                Console.Write($"Это палином ");
            }
            else
            {
                Console.Write($" Это не палином ");
            }