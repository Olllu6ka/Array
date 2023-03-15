using System;
using System.Linq; //Пришлось использовать

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев.После чего
        //пользователь вводит диапазон(например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо
        //определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была
        //минимальна с учетом выбранного диапазона.
        static void Main(string[] args)
        {
            void MoneyComp (int MoneyMth, int FirstP, int SecondP)
            {
                int[] arrayM = new int[MoneyMth];
                int[] arrayP = new int [SecondP];
                for (int i = 0; i < arrayM.Length; i++){
                    Console.Write($"\nВведите сколько денег пришло за {i} месяц: ");
                    arrayM[i] = int.Parse(Console.ReadLine());
                }
                //Console.Clear();
                for (int i = FirstP - 1 ; i < SecondP ; i++){
                    arrayP[i] = arrayM [i];
                }
                Console.WriteLine($"Минимально заработали вы с {FirstP} до {SecondP} " + arrayP.Min() + " <-- Минимальная" + arrayP.Max()+ " <-- Максимальная");
            }
            Console.Write("Введите сколько месяцев вы хотите обчислить свою прибыль: ");
            int elements = int.Parse(Console.ReadLine());
            Console.Write("Введите первый диапазон = ");
            int PeriodF = int.Parse(Console.ReadLine());
            Console.Write("Введите второй диапазон = ");
            int PeriodS = int.Parse(Console.ReadLine());
            MoneyComp(elements, PeriodF, PeriodS);
            

        }
    }
}
