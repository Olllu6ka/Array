using System;

namespace _7
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создает метод, который в качестве аргументов принимает:
        //1)целочисленный массив(int[] array), 2)целочисленный индекс(int index), 3)количество
        //элементов(int count), возвращает целочисленный массив элементов(int[] subArray).
        //Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции
        //указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
        static void Main(string[] args)
        {
            int Array( int count,int index){
                int[] array = new int [count];
                for(int g = index; g < array.Length; g++)
                {
                Console.Write($"\nВведите элемент масива {g}: ");
                array[g] = int.Parse(Console.ReadLine());
                }
                for (int i = index; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                return count;
            }
            Console.Write("Введите количество элементов = ");
            int Count = int.Parse(Console.ReadLine());
            Console.Write("Введите индекс = ");
            int Index = int.Parse(Console.ReadLine());
            Array(Count, Index);
        }
    }
}
