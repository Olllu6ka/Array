using System;

namespace _2
{
    //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
    //Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
    //все элементы массива в обратном порядке.
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [5]  { 1, 2, 3, 4, 5 };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
