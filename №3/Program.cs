using System;

namespace _3
{
    //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
    //Создайте программу, в которой создайте два строковых массива с именами Aи B(размерностью
    // 4 элемента). Массив A заполняется в цикле пользователем.Получить результирующий массивB,
    //обратный к исходному массивуA(элементы массива B идут в обратном порядке по отношению к
    //массиву A).
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для масива: ");
            int elements = int.Parse(Console.ReadLine());
            int[] arrayA = new int[elements];
            int[] arrayB = arrayA;
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write($"\nВведите элемент масива {i}: ");
                arrayA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine($"Ввывод масива А - элемент масива {i} - " + arrayA[i]);
            }
            Console.WriteLine("\n");
            for (int i = arrayB.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine($"Ввывод масива B - элемент масива {i} - " + arrayB[i]);
            }


        }
    }
}
