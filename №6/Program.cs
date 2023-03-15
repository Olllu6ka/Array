using System;
using System.Linq;

namespace _6
{
    class Program
    {
        //Используя Visual google translateStudio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создайте массив размера N элементов(размер массива задет
        //пользователь), заполнить его произвольными целыми значениями.Вывести на экран:
        //наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
        //среднее арифметическое всех элементов, вывести все нечетные значения.
        static void Main(string[] args)
        {
            Console.Write("Введите число для масива: ");
            int elementsarray = int.Parse(Console.ReadLine());
            int[] arrayA = new int[elementsarray];
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write($"\nВведите элемент масива {i}: ");
                arrayA[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nМеню:" + 
                "\nНаибольшее значение массива = 1" +
                "\tНаименьшее значение массива = 2" +
                "\nОбщую сумму всех элементов = 3" +
                "\tСреднее арифметическое всех элементов = 4"+
                "\nВывести все нечетные значения = 5" + "\nВведите = ");

            int Elements = int.Parse(Console.ReadLine());
            switch (Elements)
            {
                case 1:
                    Console.WriteLine(arrayA.Max() + " <-- Максимально значение");
                    break;
               case 2:
                    Console.WriteLine(arrayA.Min() + " <-- Минимальное значение");
                    break;
                case 3:
                    Console.WriteLine(arrayA.Sum() + " <-- Сумма всех элементов");
                    break;
                case 4:
                    Console.WriteLine((arrayA.Sum()/elementsarray) + " <-- Среднее арифметическое всех элементов");
                    break;
                case 5:
                    for (int i = 0; i < arrayA.Length; i++)
                    {
                        if (arrayA[i] % 2 != 0)
                        {
                            Console.WriteLine(arrayA[i] + $" <--- Данное число нечетное и на ходится оно под номером - {i}");
                        }
                    }
                    break;
            }
        }
    }
}
