using System;

namespace _8
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создайте метод, который будет выполнять увеличение длины
        //массива переданного в качестве аргумента, на 1 элемент.Метод, должен принимает два
        //аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value.В теле
        //метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
        //при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого
        //массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
        static void Main(string[] args)
        {
            void Foo(int count,int index) {
                int [] arrayA = new int[count];
                for (int g = index; g < arrayA.Length; g++)
                {
                    Console.Write($"\nВведите элемент масива {g}: ");
                    arrayA[g] = int.Parse(Console.ReadLine());
                }
                for (int i = index; i < arrayA.Length; i++)
                {
                    Console.WriteLine(arrayA[i]);
                }
                int[] arrayB = new int[0];
                Array.Resize(ref arrayB, count + 1);
                Array.Copy(arrayA, 0, arrayB, 1, 6);
                Console.WriteLine("Робота второго масива 2 ");
                for (int i = 1; i < arrayB.Length; i++)
                {
                    Console.WriteLine(arrayA[i]);
                }
            }
            Console.Write("Введите размерность масива = ");
            int Count = int.Parse(Console.ReadLine());
            Console.Write("Введите индкес скакого вы хотите начать = ");
            int Index = int.Parse(Console.ReadLine());
            Foo(Count, Index);
        }
    }
}
