namespace Lesson4._1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            //1. Создать массив элементов произвольного типа. 
            //С помощью циклов перебрать все элементы этого массива и вывести их на консоль.
            int[] numArray = new int [5];
            Random randomNumbers = new Random();

            Console.Write($"Заполение массива и вывод значений элементов циклом for {"\n"}");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumbers.Next(20);
                Console.WriteLine("Индекс элемента массива " + i + " = Значение " + numArray[i]);
            }

            Console.Write($"{"\n"}Вывод значений элеметнов массива циклом foreach {"\n"}");
            foreach (int i in numArray)
            {
                Console.WriteLine("Значение элемента массива: " + i);
            }

            Console.Write($"{"\n"}Вывод элементов массива циклом while {"\n"}");
            int count = 0;
            while (numArray.Length > count)
            {
                count++;
                Console.WriteLine("Значение элемента массива: " + count);
            }

            Console.Write($"{"\n"}Вывод элементов массива циклом do while {"\n"}");
            int countCheck = 0;
            do
            {
                Console.Write(countCheck);
            }
            while (numArray.Length > countCheck++);

            Console.ReadKey();
        }
    }
}
