using System;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        //Создайте программу, в которой создайте метод, который в качестве параметра принимает слово,
        //а возвращает тоже слово, но с измененным порядком букв в слове на обратный.

        
        static void Main(string[] args)
        {
            void Word(string FirstWord){

                string [] array = {FirstWord,"dlav"};
                for (int i = 0; i < array.Length; i++){
                    
                    Console.WriteLine(array[i]+"\tВывод вашего слова");
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i] + "\tОбратка");
                }
                
            }
            Console.Write("Введите слово = ");
            string WordFirst =  (Console.ReadLine());
            Word(WordFirst);
            
        }
    }
}
