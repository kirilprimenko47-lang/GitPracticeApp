namespace GitPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Програма для лабораторної роботи з Git ===");
            Console.WriteLine("Студент: Применко Кирило");
            Console.WriteLine("Версія 3.0 (develop): Додано модуль калькулятора (Calculator).");

            int a = 15;
            int b = 27;
            Console.WriteLine($"Результат додавання {a} + {b} = {Add(a, b)}");
            Console.WriteLine($"Результат множення {a} * {b} = {Calculator.Multiply(a, b)}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
