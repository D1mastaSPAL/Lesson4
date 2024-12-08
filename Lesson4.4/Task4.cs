namespace Lesson4._4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            //4. Перемещение фигуры в зависимости от от введенного символа (W, S, A, D). 
            Console.CursorVisible = false;  
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.W)
                {                           
                    Console.WriteLine("Вы перенесли фигуру вверх");
                }
                else if (pressedKey.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Вы перенесли фигуру влево");
                }
                else if (pressedKey.Key == ConsoleKey.S)
                {
                    Console.WriteLine("Вы перенесли фигуру вниз");
                }
                else if (pressedKey.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Вы перенесли фигуру вправо");
                }
                else
                {
                    Console.WriteLine("Вы не перенесли фигуру!");
                }
            }
        }
    }
}
