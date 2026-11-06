namespace GitPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Програма для лабораторної роботи з Git ===");
            Console.WriteLine("Студент: Применко Кирило");
            Console.WriteLine("Версія 2.0: Додано базові математичні обчислення та модуль привітання.");

            int a = 15;
            int b = 27;
            Console.WriteLine($"Результат додавання {a} + {b} = {Add(a, b)}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
