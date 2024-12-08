using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4._2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            //С помощью цикла со счетчиком вывести на экран в одну строку все двузначные числа, кратные 5.

            int[] numArray = new int[10];
            Random randomNumbers = new Random();
            Console.Write($"Компьютер создал массив из 10 разных чисел. {"\n"}{"\n"}Двузначные числа, которые кратные 5: {"\n"}{"\n"}");  
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumbers.Next(250);

                if (numArray[i] > 9)
                {
                    if (numArray[i] % 5 == 0)
                    {
                        Console.Write(numArray[i] + "\t");
                    }
                }
            }
           Console.ReadKey();
        }
    }
}
