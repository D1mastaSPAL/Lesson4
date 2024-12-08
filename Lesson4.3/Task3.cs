using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4._3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            //3. С помощью цикла с постусловием вывести на экран в столбик последовательность чисел : -20, -40, ...,-100.

            int x = 0;
            do
            {
                x -= 20;
                Console.WriteLine(x);
            }
            while (x != -100);
            Console.ReadKey();
        }
    }
}
