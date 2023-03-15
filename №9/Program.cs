using System;
using System.Linq;

namespace _9
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его
        //случайными элементами.Выведете на консоль полученный массив. Найдите суммы элементов
        //каждой строки, произведения элементов каждого столбца, и максимальный элемент главной
        //диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
        static void Main(string[] args)
        {
            void Foo(int count){
                int[,] array = new int [count,count];
               
                Random random = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                  for (int j = 0; j < array.GetLength(1); j++)
                  {
                   array[i, j] = random.Next(100);
                  }
                }
                Console.Write("Меню: " + "\n1)Вывод масива - 1" + 
                    "   2)Сумма элементов каждой строки - 2" + "\n3)Произведения элементов каждого столбца - 3" + 
                    "   4)Максимальный элемент главнойдиагонали - 4" + "\nВведите число: ");
                int Function = int.Parse(Console.ReadLine());
                switch (Function)
                {
                    case 1:
                        Console.WriteLine("Вывод масива");
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write(array[i, j] + "\t"); 
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("");
                        int[] arrayB = new int [10];
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j <array.GetLength(1); j++)
                            {  
                                    arrayB[i] = arrayB[i] + array[i,j];
                            }
                            Console.WriteLine(arrayB[i] + $"- Сумма - {i} столбца");
                        }

                        break;
                    case 3:
                        int[] arrayC = new int[10];
                        arrayC[0] = array[0, 0];
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                arrayC[i] = array[i,j] * array[i, j];
                            }
                            Console.WriteLine(arrayC[i] + $" - Произведение - {i} столбца");
                        }
                        break;
                    case 4:
                        int max;
                        max = array[0, 1];
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                                if (max < array[i, j]){
                                    max = array[i, j];
                                }
                        }
                        Console.Write("Максимальный элемент,лежащий выше главной диагонали равен: " + max);
                        break;
                }
            }
            Console.Write("Введите размерность масива: ");
            int Count = int.Parse(Console.ReadLine());
            Foo(Count);
        }
    }
}
