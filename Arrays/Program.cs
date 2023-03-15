using System;

namespace Arrays
{
    //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
    //Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
    //все элементы массива.
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5};
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
