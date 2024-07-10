using System;

namespace Lessons
{
    internal class Hohmework
    {
        

        public static void Main(String[] args)
        {
            Console.WriteLine("Введите первое(меньшее) число: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе(большее) число: ");
            int second = int.Parse(Console.ReadLine());

            int[] array = GetSequence(first, second);

            if (first > second) 
            {
                Console.WriteLine("Первое число больше второго. Error!!! Alarma!!! Wrong!!! AAA!!! System crash!!!");
            }

            //Задание 1.
            //Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            //Использовать рекурсию, не использовать циклы.
            //WriteBetween(first, second);

            //Задание 2.
            //Напишите программу вычисления функции Аккермана с помощью рекурсии.
            //Даны два неотрицательных числа m и n.
            //AccermanFunction(first, second);

            //Задание 3.
            //Задайте произвольный массив.Выведете его элементы, начиная с конца.
            //Использовать рекурсию, не использовать циклы.
            //WriteReverce(array);
        }

        static void WriteBetween(int a, int b)
        {
            if (a > b)
                return;

            Console.Write(a + " ");
            WriteBetween(a + 1, b);
        }

        static int AccermanFunction(int n, int m)
        {
            if (n == 0) return m + 1;
            if (n != 0 && m == 0) return AccermanFunction(n - 1, 1);
            if (n > 0 && m > 0) return AccermanFunction(n - 1, AccermanFunction(n, m - 1));
            return AccermanFunction(n, m);
        }

        static void WriteReverce(int[] numbers)
        {
            if(numbers.Length == 0) 
                return;

            Console.Write(numbers[numbers.Length - 1] + " ");
            WriteReverce(numbers.Take(numbers.Length - 1).ToArray());
        }

        private static int[] GetSequence(int first, int Second)
        {
            List<int> result = new List<int>();
            for (int i = first; i <= Second;  i++)
            {
                result.Add(i);
            }
            return result.ToArray();
        }
    }
}
